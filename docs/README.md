# NAI
# MP_2

#<b><i>Perceptron</i></b>

Celem jest napisanie programu, który pobiera następujące argumenty:

train-set: nazwa pliku zawierającego zbiór treningowy w postaci csv lub txt 

test-set: nazwa pliku zawierającego zbiór testowy w postaci csv lub txt 

Program uczy się na danych z train-set, a następnie dokonuje klasyfikacji pliku test-set. Jeśli błąd klasyfikacji przekracza parametr t (procent dopuszczalnego błędu) to program powtarza trening do momentu uzyskania błędu nieprzekraczającego t.  

Jako dane można wziąć: 

dane 2-wymiarowe sztucznie wygenerowane, np. pary liczb, x, y takie, że x+y=-1 (np.) 

dane iris – setosa vs. pozostałe kwiaty 

Program ma też dostarczać testowy interfejs (niekoniecznie graficzny), który umożliwia ręczne testowanie perceptronu. Czyli podamy mu dane testowe ręcznie i sprawdzimy wynik na wyjściu. 

<b>UWAGI:</b> 

Liczba wymiarów wektorów powinna być zmienna, wczytywana z danych, a nie wpisana na sztywno w kodzie.  

Przykładowe klasy: Perceptron (pola: weights[], threshold, dimension, learninRate; metody: compute, learn), Trainer (pola np.: dane, trainTestRatio, dimension, learninRate, etc.), UI 
Po każdej modyfikacji wag warto normalizować wektor.

Nie można korzystać z gotowych bibliotek typu wektor, perceptron itp. Można korzystać z gotowych kolekcji (Array listy itp.,), klasy Math i klas do wczytywania danych
