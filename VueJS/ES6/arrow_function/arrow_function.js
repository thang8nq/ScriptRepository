//open console window F12 to check result
//2 normal ways to define a function
function func1(name, age)
{
    return `func1: My name is ${name}, ${age} years old`;
}
console.log(func1("thang", 25));

var func2 = function(name, age)
{
    return `func2: My name is ${name}, ${age} years old`;
}
console.log(func2("anh", 22));

//arrow function, using arrow symbol => 
var func3Arrow = (name, age) => 
{
    return `func3Arrow: My name is ${name}, ${age} years old`;
}
console.log(func3Arrow("quang", 24));

//if there is a line, can skip block {}, same like C#, hehe
//only a line, not using return, use return will be error, => like return
var func4Arrow = (name, age) => `func4Arrow: My name is ${name}, ${age} years old`;
console.log(func4Arrow("quang", 24));

//if there is only 1 input param, unnecessary using ()
var func5Arrow = name => `func5Arrow: My name is ${name}`;
console.log(func5Arrow("hai"));

//if there is no input param, must using ()
var func6Arrow = () => `func6Arrow: There are no input param`;
console.log(func6Arrow());