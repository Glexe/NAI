from sys import argv
from LanguageRecognizer import LanguageRecognizer


def exception(msg):
    print(f"-1,{msg}")
    exit(-1)


is_debug_mode = False
if is_debug_mode:
    argv = ["",
            "D:/Stud/Jetbrains/apps/PyCharm-P/Projects/train_data_r.txt",
            "D:/Stud/Jetbrains/apps/PyCharm-P/Projects/test_data_r.txt",
            "1",
            "Mia madre è insegnante, mio padre è medico e i miei fratelli sono studenti. Mia mamma si chiama Lucia e ha quaranta anni; mio padre ha quarantadue anni e si chiama Luca, mio fratello si chiama Giovanni ha 15 anni e mia sorella invece si chiama Emma e ha 10 anni."]


# 1:addr 2:train path 3:test path 4: language_group 5: input text to classify
args_count = len(argv)
if args_count != 5 & args_count != 4:
    exception("Wrong number of arguments, must be: 5, got: "+args_count.__str__())


neural_network = LanguageRecognizer(argv[1], argv[2], int(argv[3]))
test_result = neural_network.get_test_result()

if args_count == 4:
    print("Accuracy: " + test_result.__str__() + "%")
else:
    print(neural_network.classify_language(argv[4]))

