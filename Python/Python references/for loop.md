# FOR LOOP


---


# DESCRIPTION

The for loop is used to iterate over a given sequence, or iterables (like range, list, a tuple, a dictionary, a set, a string).
It is common to use the for loop when the number of iterations is fixed.
Both, for and while loops can be used to achieve the same results, however, the for loop has cleaner and shorter syntax, making it a better choice in most cases.


---


# SYNTAX STRUCTURE

```python
for i in range (5):    # definitive iteration (total 5) (i from 0 to 4)
    statement 1     # /Body starts. Execute till last item in sequence.
    statement 2     # loop statement must be properly indented
    ...
    statement n     # /Body of statements stops
else:               # Else block is optional
    statement(s)    # execute only when for loop executes normally
```


---


# BREAK & CONTINUE STATEMENT

```python
for i in range (5):
    print(i)
    if i == 0:
        break;     # break a while loop prematurely
    elif i == 1:
        continue;    # jumps back to the top of the loop to the next itteration
```
```
> 0
```


---


# ITERATE THROUGHA A LIST

```python
listWords = ["hello", "world", "spam", "eggs"]
for word in listWords:      # variable WORD represents the corresponding item of the list in each iteration of the loop.
    print(word + "!")
```
```
> hello!
> world!
> spam!
> eggs!
```

---


# ITERATE OVER STRINGS

```python
str = "testing for loops"
for x in str:
    print(x)
```
```
> t
> e
> s
> t
> i
> n
> g
> 
> f
> o
> r
> 
> l
> o
> o
> p
> s
```


---


# ITERATE INA RANGE

```python
for i in range(5):      # i from 0 to 4
    print("hello!")
```
```
> hello!
> hello!
> hello!
> hello!
> hello!
```
