let courseWeb = ["PHP", "Javascript", "HTML"];
let courseMobile = ["Android", "IOS"];

let course = ["Python", "UWP"];

console.log(course);

//using spread operator ...
let course2 = ["Python", ...courseWeb, "UWP", ...courseMobile];
console.log(course2);

//if not using spread operator
let course3 = ["Python", courseWeb, "UWP", courseMobile];
console.log(course3);