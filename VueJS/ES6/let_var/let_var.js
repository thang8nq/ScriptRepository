/**
*  - param defined with var using as global,  nomatter where it defined (inside any scope like if/for/while/...) as long as it defined before the first called
*/
// var point = 50; 
// if(point > 10) {
//     var msg = "WIN";
//     console.log("inside if: msg = " + msg);
// }
// console.log("outside if: msg = " + msg); //using as global

// for(var x = 1; x < 3; x++) {
//     //do smt
// }
// console.log("x: " + x); //after end for loop, x=3 -> print 3



/** 
 * param defined with var, then define new param with same name is acceptable, it consider as new assignment 
 */
// if(3 > 2) {
//     var msg2 = "true";
//     console.log(msg2);
// }
// var msg2 = "false";
// console.log(msg2); //print false, no error although "msg2" defined before



/**
 * param defined without var, consider as var 
 */
// if(3 > 2) {
//     msg3 = "true3";
//     console.log(msg3);
// }
// msg3 = "false3";
// console.log(msg3);



/**
 * param defined with let, only exist in the scope where it defined
 * NOTE: javascript will stop if face the error, script after error will not be execute (need to rem the error below to print msg2Fix)
 */
// let point = 50; 
// let msg2Fix;
// if(point > 10) {
//     let msg = "win";
//     console.log(msg); //print "win"
//     msg2Fix = "win2";
// }
// console.log(msg); //error - undefined 
// console.log(msg2Fix); //ok



/**
 * cannot define new param same name with previous if using let (same C++)
 */
// let point = 50;
// console.log(point);
// let point = 30; //error already declared
// console.log(point);



/**
 * when define a param with let, then can only using it without var/let to assign new value -> mean param let exist unique
 */
// let point = 50;
// point = 10; //ok -> assign new value
// let point = 30; //error -> already declare

/**
 * also error, if there is a let param, no var param with same name in same scope. mean in a scope, there is only a let param with unique name
 */
// var point = 50; 
// let point = 30; //error

/**
 * also error, because let's scope > var's scope
 */
// if(3 > 2)
// {
//     var point = 5; 
// }
// let point = 4; 

/**
 * ok, because let's scope < var's scope
 */
// if (3 > 2) {
//     let point = 4;
// }
// var point = 5;
