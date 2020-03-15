/**
 * https://developer.mozilla.org/vi/docs/Web/JavaScript/Reference/Global_Objects/Array/forEach
 * array.foreach() : executes a provided function once for each array element
 * example: 
 * const array1 = [1, 3, 4]
 * array1.foreach(element => console.log(element)); --> for each array element, print it
 */

//Case 1: 
// let student = {
//     name: "Thang", 
//     course: ["HTML", "CSS", "JavaScript"], 
//     showInfo: function() {
//         this.course.forEach(function(course){
//             console.log(`${this.name} is studying ${course}`); //${this.name} return an empty value    
//         })
//     }
// }

//Case 2: using a param to store this outside the sub function showInfo
// let student = {
//     name: "Thang", 
//     course: ["HTML", "CSS", "JavaScript"], 
//     showInfo: function() {
//         var _this = this;
//         this.course.forEach(function(course){
//             console.log(`${_this.name} is studying ${course}`); 
//         })
//     }
// }

//Case 3: using bind(this) to function
// let student = {
//     name: "Thang", 
//     course: ["HTML", "CSS", "JavaScript"], 
//     showInfo: function() {
//         this.course.forEach(function(course){
//             console.log(`${this.name} is studying ${course}`);
//         }.bind(this))
//     }
// }

/**
 * Case 4: using arrow function -> will using this to code (showInfo)
 * -> remove "function" keyword
 * -> adding "=>" symbol
 * -> remove "()" because there is only 1 input param is "course"
 * -> remove "{}" because there is only 1 command, and also remove ";"
 */
let student = {
    name: "Thang", 
    course: ["HTML", "CSS", "JavaScript"], 
    showInfo: function() {
        this.course.forEach(course => console.log(`${this.name} is studying ${course}`))
    }
}

student.showInfo();