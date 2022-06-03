with open ("../Inputs/2019_01.txt") as f:
    input_data = f.readlines()

total_fuel = 0
# PART 1
for i in input_data:
    fuel = int(i) // 3 - 2

    total_fuel += fuel
    
print(total_fuel)

# PART 2
total_fuel = 0
for i in input_data:
    fuel = int(i) // 3 - 2
    
    while not fuel <= 0 :
        total_fuel += fuel
        fuel = fuel // 3 - 2
        print(fuel)


print(total_fuel)