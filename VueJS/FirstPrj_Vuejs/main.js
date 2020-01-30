var vueInstance = new Vue({
    el: '#app',
    data: {
        count: 1, 
        posX: 0, 
        posY: 0
    }, 
    methods: {
        getLocation(e){
            this.posX = e.clientX;
            this.posY = e.clientY;
        }
    }
});

console.log(vueInstance);