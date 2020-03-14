//open console window F12 to check the result
//define an array string
let nameArr = [
    "nguyen",
    "thang",
    "quang"
];

console.log("print array string with common way");
let sizeArr = nameArr.length;
for(let i = 0; i < sizeArr; i++)
{
    console.log(nameArr[i]);
}

console.log("print array string with for in");
for(let index in nameArr)
{
    console.log(nameArr[index]);
}

console.log("print array string with for of");
for(let pro of nameArr)
{
    console.log(pro);
}


//define an object 
let dev = {
    name: "thang", 
    age: 25, 
    sex: "male"
};

console.log("print object with for in");
for(let index in dev)
{
    console.log(index + " : " + dev[index]);
}

for(let pro of dev)
{
    //console.log(pro); //get error --> undefined
}