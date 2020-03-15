class Student {
    constructor(code, name, age) {
        this.code = code; 
        this.name = name; 
        this.age = age;
    }

    showInfo() {
        return this.name + " - " + this.getAge();
    }

    getAge() {
        let today = new Date();
        let year = today.getFullYear();
        return year - this.age;
    }
}

//let studentObj = new Student(); //undefined
let studentObj = new Student("20146662", "Nguyen Quang Thang", 1996);

console.log(studentObj.showInfo());


//Inheritance 
class Student2 extends Student {
    constructor(code, name, age, score) {
        super(code, name, age);
        this.score = score;
    }

    showInfo() {
        console.log("this from Student2");
        console.log(super.showInfo() + " - score: " + this.score);
    }
}

let studentObj2 = new Student2("20146662", "Nguyen Thang", 1996, 3.1);
studentObj2.showInfo();