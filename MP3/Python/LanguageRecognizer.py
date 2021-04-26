import string
from sys import argv

from Perceptron import Perceptron
import numpy as np


def exception(msg):
    print(f"-1,{msg}")
    exit(-1)


# region Funcs


def softmax(xs):
    return np.exp(xs) / sum(np.exp(xs))


def format_input(text):
    whitelist = string.ascii_lowercase
    new_s = ""
    for char in text:
        if char in whitelist:
            new_s += char
    return new_s


def calculate_frequency(line: str):
    alph = {
        'a': 0,
        'b': 0,
        'c': 0,
        'd': 0,
        'e': 0,
        'f': 0,
        'g': 0,
        'h': 0,
        'i': 0,
        'j': 0,
        'k': 0,
        'l': 0,
        'm': 0,
        'n': 0,
        'o': 0,
        'p': 0,
        'q': 0,
        'r': 0,
        's': 0,
        't': 0,
        'u': 0,
        'v': 0,
        'w': 0,
        'x': 0,
        'y': 0,
        'z': 0,
    }
    line = format_input(line)
    chars_count = len(line)
    tmp_list = []
    for char in line:
        alph[char] += 1
    for key in alph:
        tmp_list.append(alph[key] / chars_count)
    return tmp_list


def read_file(path: string, dictionary: dict):
    try:
        with open(path, encoding='utf-8') as reader:
            lines = reader.readlines()
            for line in lines:
                splitted_line = line.split(',', 1)
                language_id = splitted_line[0]
                text = splitted_line[1]
                dictionary[language_id].append(text.replace('\n', '').strip())
    except IOError:
        exception("IO exception has occurred, please check if file paths are correct")
    except KeyError:
        exception("Given training file and language group do not match each other")
    finally:
        reader.close()


def get_frequencies(path: string, dictionary: dict):
    read_file(path, dictionary)
    tmp_dict = {}

    for key in dictionary:
        tmp_frequency_list = []
        for line in dictionary[key]:
            tmp_frequency_list.append(calculate_frequency(line))
        tmp_dict[key] = tmp_frequency_list
    return tmp_dict


def get_language_group_dictionary(language_group_id: int):
    if language_group_id == 1:
        return {
            'Italian': [],
            'Spanish': [],
            'Portuguese': []
        }
    else:
        if language_group_id == 2:
            return {
                'Danish': [],
                'Norwegian': [],
                'Swedish': []
            }
        else:
            exception("Wrong language group id: " + argv[3])


# endregion

epochs = 500
hidden_layer_size = 6

# region Outputs
outputs_first_language = [1], [1], [1], [1], [1], [1], [1], [1], [1], [0], [0], [0], [0], [0], [0], [0], [0], [0], [
    0], [0], [0], [0], [0], [0], [0], [0], [0]
outputs_second_language = [0], [0], [0], [0], [0], [0], [0], [0], [0], [1], [1], [1], [1], [1], [1], [1], [1], [
    1], [0], [0], [0], [0], [0], [0], [0], [0], [0]
outputs_third_language = [0], [0], [0], [0], [0], [0], [0], [0], [0], [0], [0], [0], [0], [0], [0], [0], [0], [0], [
    1], [1], [1], [1], [1], [1], [1], [1], [1]

outputs = [outputs_first_language, outputs_second_language, outputs_third_language]


# endregion


class LanguageRecognizer(object):
    def __init__(self, train_set_filepath: string, test_set_filepath: string, language_group_id: int):
        self.train_set_filepath = train_set_filepath
        self.test_set_filepath = test_set_filepath
        self.language_group_id = language_group_id

        self.train_data = []
        self.test_data = []
        self.perceptrons = []
        self.languages_dict = {}

        self.__load_data()
        self.train_perceptrons()

    def __load_data(self):
        self.languages_dict = get_language_group_dictionary(self.language_group_id)
        frequencies = get_frequencies(self.train_set_filepath, self.languages_dict)
        for key in frequencies:
            self.train_data += frequencies[key]

        frequencies = get_frequencies(self.test_set_filepath, self.languages_dict)
        for key in frequencies:
            self.test_data.append(frequencies[key])

    def train_perceptrons(self):
        train_data = np.array(self.train_data)

        for output_array in outputs:
            tmp_percep = Perceptron(train_data, output_array)
            input_layer_size = len(self.train_data[0])
            tmp_percep.resize_weights(input_layer_size, hidden_layer_size)
            tmp_percep.train(epochs)
            self.perceptrons.append(tmp_percep)

    def get_test_result(self):
        count_true = 0
        count_false = 0
        for i in range(len(self.test_data)):
            for line in self.test_data[i]:
                test_results = [self.perceptrons[0].get_result(line), self.perceptrons[1].get_result(line),
                                self.perceptrons[2].get_result(line)]
                highest_value = max(softmax(test_results))
                if softmax(test_results)[i] != highest_value:
                    count_false += 1
                else:
                    count_true += 1
        return int((count_true / (count_false + count_true)) * 100)

    def classify_language(self, input_text: string):
        input_data = calculate_frequency(input_text)
        test_results = [self.perceptrons[0].get_result(input_data), self.perceptrons[1].get_result(input_data),
                        self.perceptrons[2].get_result(input_data)]
        highest_value = max(softmax(test_results))
        if softmax(test_results)[0] == highest_value: return list(self.languages_dict.keys())[0]
        if softmax(test_results)[1] == highest_value: return list(self.languages_dict.keys())[1]
        if softmax(test_results)[2] == highest_value: return list(self.languages_dict.keys())[2]
