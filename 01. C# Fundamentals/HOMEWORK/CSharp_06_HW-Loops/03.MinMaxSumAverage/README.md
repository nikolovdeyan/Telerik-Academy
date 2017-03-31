###### [My Telerik Academy Courses](https://github.com/nikolovdeyan/TelerikAcademy) 
-------------------------------------

MMSA (Min, Max, Sum, Average) of N Numbers
==============================

## Description
Write a program that reads from the console a sequence of **N** real numbers and returns the *minimal*, the *maximal* number, the *sum* and the *average* of all numbers (displayed with 2 digits after the decimal point).
  - The input starts by the number **N** (alone in a line) followed by **N** lines, each holding an real number.
  - The output is like in the examples below.

## Input
- On the first line, you will receive the number **N**.
- On each of the next **N** lines, you will receive a single real number.

## Output
- You output must always consist of *exactly* 4 lines - the minimal element on the first line, the maximal on the second, the sum on the third and the average on the fourth, in the following format:

```
min=3.00
max=6.00
sum=9.00
avg=4.50
```

## Constraints
- 1 <= **N** <= 1000
- All numbers will be valid integer numbers that will be in the range `[-10000, 10000]`
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

|       Input       |               Output                 |
|-------------------|--------------------------------------|
| 3<br>2<br>5<br>1  | min=1.00<br>max=5.00<br>sum=8.00<br>avg=2.67  |
| 3<br>2<br>-1<br>4 | min=-1.00<br>max=4.00<br>sum=5.00<br>avg=1.67 |

## Submission
- Submit your code [here](http://bgcoder.com/Contests/Compete/Index/312#2)
