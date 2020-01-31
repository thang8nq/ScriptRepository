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
        getLocation(e, number){
            this.posX = e.clientX;
            this.posY = e.clientY;
        }, 
        getLocationChild(e, number){
            this.posXBox2 = e.clientX; 
            this.posYBox2 = e.clientY;
        }
    }
});

console.log(vueInstance);