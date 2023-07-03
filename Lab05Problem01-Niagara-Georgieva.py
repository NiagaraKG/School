start = int(input("Enter a low value: "))
end = int(input("Enter a high value: "))
step = int(input("Enter a step value: "))
print()
print(" " * 4, "Pounds", " " * 4, "Ounces"," " * 4,"Grams")
for pounds in range(start, end + 1, step):
    ounces = pounds * 16.0
    grams = pounds * 453.592
    print("{:11.1f} {:11.1f} {:11.1f}".format(pounds, ounces, grams))