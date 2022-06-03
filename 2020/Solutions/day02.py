with open ("../Inputs/2020_02.txt") as f:
    input_data = f.readlines()

input_data = [i.split() for i in input_data]
#PART 1
valid_pass = 0
for data in input_data:
    range_char = data[0].split("-")
    lowest = int(range_char[0])
    highest = int(range_char[1])

    choosen_char = data[1][0]

    password = data[2]
    num_of_chars = 0    
    valid = False

    for chars in password:
        if chars == choosen_char:
            num_of_chars += 1

    if not num_of_chars in range(lowest, highest+1):
        valid = False
    else:
        valid = True

    if valid:
        valid_pass += 1
print(valid_pass)

# PART 2


valid_pass = 0
for data in input_data:
    range_char = data[0].split("-")
    first = int(range_char[0])
    second = int(range_char[1])

    choosen_char = data[1][0]

    password = data[2]
    num_of_chars = 0    
    valid = False
    already_checked = False

    for index, chars in enumerate(password):
        if index == first-1 and chars == choosen_char:
            if already_checked:
                valid = False
                break
            num_of_chars += 1
            already_checked = True
            valid = True
        if index == second-1 and chars == choosen_char :
            if already_checked:
                valid = False
                break
            num_of_chars += 1
            already_checked = True
            valid = True

    if valid:
        valid_pass += 1
        valid = False
print(valid_pass)


