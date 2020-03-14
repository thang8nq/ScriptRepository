//open console to check result
//define an array
let arrDes = [123, "thang", "thai binh"];

//normal way
// let id = arrDes[0];
// let name = arrDes[1];
// let address = arrDes[2];

//using destructuring
let [id, name, address] = arrDes;
//console.log(id + " " + name + " " + address);

//define an object
let info = {
    id1 : 28, 
    name1: "thang", 
    age: 25, 
    sex: "male"
}

//correct if not in order, just need exactly name
//let {name1, id1, sex, age} = info;
//console.log(id1 + " " + name1 + " " + age + " " + sex);

//let dev = {dev_id, dev_name, dev_age, dev_sex} = info;
//console.log(dev_id + "-" + dev_name + "-" + dev_age + "-" + dev_sex); //undefined
//console.log(dev.dev_id + "-" + dev.dev_name + "-" + dev.dev_age + "-" + dev.dev_sex); //undefined
//console.log(dev.id1 + "-" + dev.name1 + "-" + dev.age + "-" + dev.sex); //ok, using same attribute

//using default value, if same -> get same first, then default --> nam1 is thang instead of hai
let {id2 = 21, name1 = "hai", age, sex2 = "female"} = info;
console.log(id2 + "-" + name1 + "-" + age + "-" + sex2);
