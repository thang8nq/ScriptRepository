/**
 * Property value shorthand: 
 */

 //normal way
// function getCourse(name, price, free)
// {
//     return {
//         name1 : name, 
//         price1 : price, 
//         free1 : free
//     }
// }

//using property value shorthand, not use name1, price1, free1
function getCourse(name, price, free)
{
    return {
        name, 
        price, 
        free
    }
}

console.log(getCourse("ES6", 20, true));

/**
 * Method properties
 */
let dev = {
    name : "thang", 
    age  : 25, 
    //normal way
    showInfo : function() {
        console.log(`normal way: ${this.name} - ${this.age}`);
    }, 
    //method properties, remove ":" & "function"
    showInfo2() {
        console.log(`method properties: ${this.name} - ${this.age} `);
    },
    showInfo3(delimiter = " + ") {
        console.log(`method properties using delimiter: ${this.name + delimiter + this.age}`);
    }
}

dev.showInfo();
dev.showInfo2();
dev.showInfo3(" % ");
dev.showInfo3();

/**
 * Computed property names
 */
//normal way1
let bootstrapSupport1 = {
    "support_chrome": true,
    "support_ie"    : true, 
    "support_firefox" : true
}
//normal way2
let bootstrapSupport2 = {
    ["support_chrome"]: true,
    ["support_ie"]    : true, 
    ["support_firefox"] : true
}
console.log(bootstrapSupport1);
console.log(bootstrapSupport2);

//using computed property name
let prefix = "computed_pro_name_";
let bootstrapSupport3 = {
    [prefix + "chrome"]: true,
    [prefix + "ie"]    : true, 
    [prefix + "firefox"] : true
}
console.log(bootstrapSupport3);