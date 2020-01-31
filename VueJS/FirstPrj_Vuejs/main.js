var vueInstance = new Vue({
    el: '#app',
    data: {
        count: 1, 
        posX: 0, 
        posY: 0
    }, 
    methods: {
        getLocation(e, number){
            this.posX += number;
            this.posY = e.clientY;
        }
    }
});

console.log(vueInstance);