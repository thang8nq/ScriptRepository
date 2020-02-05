var vueInstance = new Vue({
    el: '#app',
    data: {
        a: 0,
        x: 10, 
        y: 5,
        number: 20
    }, 
    methods: {
        addA()
        {
            console.log("function addA");
            return this.a + this.number;
        }
    }, 
    computed: {
        addX()
        {
            console.log("computed addX");
            return this.x + this.number;
        }, 
        addY()
        {
            console.log("computed addY");
            return this.y + this.number;
        }
    }
});

console.log(vueInstance);