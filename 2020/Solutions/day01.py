with open("../Inputs/2020_01.txt") as f:
    input_data = f.readlines()

input_data = [int(i.encode("utf-8")) for i in input_data]

result = 0
for a in input_data:
    for b in input_data:
        if a + b == 2020:
            result = a * b
            break
print(result)

