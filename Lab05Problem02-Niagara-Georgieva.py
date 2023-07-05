days = int(input("How many days do you have? "))
print()
sum = 0.0
min = float("inf")
max = -1.0
for d in range(days):
    wind = float(input(f"Enter the maximum wind speed in km/h for day {d + 1}: "))
    sum += wind
    if wind < min:
        min = wind
    if wind > max:
        max = wind
average = sum / days
print()
print("Minimum speed: {:.1f} km/h".format(min))
print("Maximum speed: {:.1f} km/h".format(max))
print("Average speed: {:.1f} km/h".format(average))