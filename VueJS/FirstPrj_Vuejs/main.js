var vueInstance = new Vue({
    el: '#app',
    data: {
        count: 1, 
        posX: 0, 
        posY: 0,
        posXBox2: 0, 
        posYBox2: 0
    }, 
    methods: {
        handleSubmitForm(e){
            console.log(e);
           //event.preventDefault();
        }
    }
});

console.log(vueInstance);