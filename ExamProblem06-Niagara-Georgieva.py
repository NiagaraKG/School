'''
Задача 6:
Напишете програма, която да съдържа следното:

1. Проект с име animalshop
2. Клас наречен Dog, който няма main метод
3. Включете следните instance fields /променливи/ в dog класа:
    String name
    String breed
    String barkNoise – “Woof”
    Double weight
4. Направете конструктор, който създава dog object използвайки параметри за name, breed и weight fields. Присвоете instance fields на тези стойности.
5. Направете втори конструктор който приема стойности за всичките instance fields като параметри и присвоява съответните fields на тези стойности. 
6. Създайте Accessor and Mutator (getter and setter) методи за следните fields:
    name
    breed
    weight
7. Добавете функционален метод с име bark, който да показва стойността на barkNoise field на конзолата. 
8. Добавете overloaded функционален метод с име bark, който да приема String параметър за звука, който кучето прави, когато лае.
9. Създайте клас с име AnimalTester, който съдържа main method
10. Създайте dog1 object използвайки конструктора с 3 параметъра
11. Създайте dog2 object използвайки конструктора с 4 параметъра
12. Създайте метод повиквания за двата dog обекта, така че цялата информация за тях да се покаже на екрана
13. Използвайте instance field getter методи да произведете следния изход:
    Dog name: Cain
    Dog breed: Golden Doodle
    Bark noise: baf-baf
    Dog weight: 25.5

Изготвил решението: Ниагара Георгиева Фак. №: 223010012
24.06.2023г.
'''

"""       !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!       ЗАБЕЛЕЖКИ      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
Не съм създавала проект по първа точка, тъй като не сме го правили в лекциите (поне не в тези от графика за ДО на български език),
а в интернет откривам туториали за PyCharm, а аз ползвам VSCode.
Python не поддържа множество конструктори, с този проблем се сблъскахме и на едно от упражненията като оставихме един конструктор (има по-сложни заобиколни решения)
Python не поддържа overload по дефолт, коментирано на същата лекция (има по-сложни заобиколни решения за имитиране, но
 понеже кучето има възможност за задаване на лай при създаване или дефолтен лай, директно извеждам съдържанието на barkNoise за точки 7. и 8., тоест пропускам 8)
"""

class Dog:                                                                      #Създаваме клас Dog
    def __init__(self, name, breed, weight, barkNoise = None):                  #Създаваме конструктор като задаването на лай е по избор
        self.set_name(name)
        self.set_breed(breed)
        self.set_weight(weight)
        if barkNoise:
            self.barkNoise = barkNoise
        else:
            self.barkNoise = "Woof"

    def get_name(self):                                                         #Създаваме гетъри за желаните полета (по условие без лай)
        return self.__name
    
    def get_breed(self):
        return self.__breed
    
    def get_weight(self):
        return self.__weight

    def set_name(self, name):                                                   #Създаваме сетъри за желаните полета (по условие без лай)
            self.__name = name

    def set_breed(self, breed):
            self.__breed = breed

    def set_weight(self, weight):
            self.__weight = weight

    def bark(self):                                                             #Създаваме метод за лай (1, понеже Python не поддържа overload по дефолт)
         print("Dog noise:",self.barkNoise)

    def printInfo(self):                                                        #Създаваме метод за отпечатване на информацията (използваме bark, защото по условие няма гетър за лай, а и метода да не остане неизползван)
         print("Dog name:", self.get_name())
         print("Dog breed:", self.get_breed())
         self.bark()
         print("Dog weight:", self.get_weight())


class AnimalTester:                                                             #Създаваме клас AnimalTester с main метод
     def main():
        dog1 = Dog("Tramp", "Schnauzer", 20)                                    #Създаваме първи обект с дефолтен лай
        dog2 = Dog("Lady", "Spaniel", 11, "Bark")                               #Създаваме втори обект със зададен лай
        dog1.printInfo()                                                        #Отпечатваме информацията за двете кучета с празен ред между тях
        print()
        dog2.printInfo()

AnimalTester.main()                                                             #Изикваме main метода от AnimalTester, за да изпълним гореописаната програма