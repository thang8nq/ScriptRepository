var vueInstance = new Vue({
    el: '.app', 
    data: {
        activeColor: 'blue', 
        fontSize: 20, 
        backgroundImage: 'https://www.thepaintedturtle.org/sites/main/files/main-images/camera_lense_0.jpeg'
    }, 
    methods: {
        
    }, 
    computed: {
        background()
        {
            return 'url(' + this.backgroundImage + ')';
        }, 
        objectStyle: function(){
            return {
                //backgroundImage: 'url(' + this.backgroundImage + ')',
                backgroundImage: this.background, 
                marginTop: '20px', 
                marginLeft: '50px'

            }
        }
    }
});