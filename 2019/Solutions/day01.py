with open ("../Inputs/2019_01.txt") as f:
    input_data = f.readlines()

total_fuel = 0
for i in input_data:
    fuel = int(i) // 3 - 2
    total_fuel += fuel
print(total_fuel)
