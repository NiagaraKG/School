course_name = input("Enter a course name: ")
course_number = input("Enter a course number: ")
course_section = input("Enter a course section: ")
semester = input("Enter a semester (Winter, Summer): ")
year = int(input("Enter a year: "))
print("\nThe course code is {:.3}{}{}{:.1}{}".format(course_name, course_number, course_section, semester, year))