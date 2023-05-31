n = int(input("How many scores will be entered? "))
scores = []
print("Enter your scores:")
for i in range (n):
  scores += [int(input())]

print("\nThe scores are [", end = "")
print(*scores, sep = ", ", end = "")
print("]")

scores.sort()
print("The sorted scores are [", end = "")
print(*scores, sep = ", ", end = "")
print("]")

print("The smallest score is", scores[0])
print("The largest score is", scores[n-1])

scores_without_repetition = []
[scores_without_repetition.append(i) for i in scores if i not in scores_without_repetition]

print("\nThe frequencies are:")
print("Score  Frequency")
for i in scores_without_repetition:
  print("{:>5}  {:>9}".format(i, scores.count(i)))