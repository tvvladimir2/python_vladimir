import turtle
t = turtle.Pen()
turtle.bgcolor("black")
t.speed(0)
colors = ["red", "yellow", "blue", "green"]
for x in range(500):
    t.pencolor(colors[x%4])
    t.circle(x)
    t.left(91)
    print(x)
