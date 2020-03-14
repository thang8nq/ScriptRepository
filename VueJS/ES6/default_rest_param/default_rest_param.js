//here default param is name
function infoProduct(name = "Ryzen 7", price)
{
    console.log(`Product ${name} has price ${price}$`);
}

//call function
infoProduct(); //Ryzen 7 - undefined
infoProduct(250); //250 - undefined
//infoProduct(,250); //error --> let place the default param at the end, like infoProduct2
function infoProduct2(name, price = 200)
{
    console.log(`Product ${name} has price ${price}$`);
}


//res param area
function doOperator(op, num1, num2)
{
    let result = 0;
    switch(op)
    {
        case '+': 
            result = num1 + num2; 
            break;
        case '-': 
            result = num1 - num2;
            break;
    }
    return result;
}

//console.log(doOperator('+', 3, 5));
//console.log(doOperator('-', 3, 5));

//if, want more param (num1, num2, num3, ...) --> define new function? NOPE -> using rest param, symbol ...
function doOperatorRestParam(op, ...num)
{
    let result = 0;
    switch(op)
    {
        case '+': 
            for(let n of num)
            {
                result += n;
            }
            break;
        case '-': 
            for(let n of num)
            {
                result -= n; 
            }
            result += 2 * num[0];
            break;
    }
    return result;
}
console.log("rest param");
console.log(doOperatorRestParam('+', 1, 2, 3, 4, 5));
console.log(doOperatorRestParam('-', 1, 2, 3));