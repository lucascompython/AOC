advent_of_code::solution!(1);

pub fn part_one(input: &str) -> Option<u64> {
    let mut current: i64 = 50;
    let mut count = 0;
    for line in input.lines() {
        let op = line.chars().next()?;
        let num = line[1..].parse::<i64>().ok()?;

        match op {
            'R' => current = (current + num) % 100,
            'L' => current = (current + 100 - num) % 100,
            _ => return None,
        };

        if current == 0 {
            count += 1;
        }
    }

    Some(count)
}

pub fn part_two(input: &str) -> Option<u64> {
    None
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test_part_one() {
        let result = part_one(&advent_of_code::template::read_file("examples", DAY));
        assert_eq!(result, None);
    }

    #[test]
    fn test_part_two() {
        let result = part_two(&advent_of_code::template::read_file("examples", DAY));
        assert_eq!(result, None);
    }
}
