import numpy as np


def sigmoid(x): return 1 / (1 + np.exp(-x))  # activation func


def sigmoid_(x): return x * (1 - x)  # pochodna


class Perceptron(object):

    def __init__(self, inputs, outputs):
        self.inputs = inputs
        self.outputs = outputs
        self.hidden_layer_wages = []
        self.output_layer_wages = []

    def resize_weights(self, input_layer_size, hidden_layer_size):
        self.hidden_layer_wages = np.random.uniform(size=(input_layer_size, hidden_layer_size))
        self.output_layer_wages = np.random.uniform(size=(hidden_layer_size, 1))

    def train(self, epochs):
        for i in range(epochs):
            hidden_layer_result = sigmoid(np.dot(self.inputs, self.hidden_layer_wages))
            output_layer_result = sigmoid(np.dot(hidden_layer_result, self.output_layer_wages))

            error = self.outputs - output_layer_result

            dO = error * sigmoid_(output_layer_result)
            dH = dO.dot(self.output_layer_wages.T) * sigmoid_(hidden_layer_result)

            self.output_layer_wages += hidden_layer_result.T.dot(dO)
            self.hidden_layer_wages += self.inputs.T.dot(dH)

    def get_result(self, input):
        hidden_layer_result = sigmoid(np.dot(input, self.hidden_layer_wages))
        output_layer_result = sigmoid(np.dot(hidden_layer_result, self.output_layer_wages))
        return output_layer_result
