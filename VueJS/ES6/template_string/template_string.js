//way1
let content1 = document.getElementById("content1");
//content1.innerHTML = "Course name: Vuejs1 - price: 201$";
let course_name = "VueJs"; 
let price = 100;
content1.innerHTML = "Course name: " + course_name + " - price: " + price; 

//template_str1
let content_template_str1 = document.getElementById("content_template_str1");
content_template_str1.innerHTML = `Course name: ${course_name} - 
                                    price: ${price}`;


//template_str2
let content_template_str2 = document.getElementById("content_template_str2");

let activies = {
    id: 69, 
    name: "Styling 69", 
    status: true
}
// activies done (true) -> red, else -> blue
content_template_str2.innerHTML =   `<div id="activity-id-${activies.id}">
                                    <span class="name" style="color: ${activies.status == true ? "red" : "blue"};">
                                    ${activies.name}</span>
                                    </div>`