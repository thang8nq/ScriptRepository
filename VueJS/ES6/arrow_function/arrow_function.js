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

//more example with arrow function
/**
 * map function: create an array by doing something in each element of input array
 * example: 
 * array1 = [1, 2, 3]
 * const array2 = array1.map(x => x * 2); //[2, 4, 6]
 */
let courses = ["Android", "java", "php", "vuejs"];
console.log(
    courses.map( course => course.toUpperCase())
);

/**
 * sort function: arrange all element of array in place and return that array
 * sort(): arrange by Unicode point 
 * sort(compareCondition): arrange by compareCondition
 * compareCondition(a, b) < 0 -> a, b
 * compareCondition(a, b) > 0 -> b, a
 */
let scores = [5, 2, 6, 33, 3, 1, 53, 78];
scores.sort(
    (x, y) => x - y
);
console.log("ascending: " + scores);

scores.sort(
    (x, y) => y - x
);
console.log("descending: " + scores);