var vueInstance = new Vue({
    el: '.app', 
    data: {
        textClass: 'active', 
        isActive: true, 
        isDisable: true
    }, 
    methods: {
        changeActive() {
            this.isActive = !this.isActive;
        },
        changeDisable() {
            this.isDisable = !this.isDisable;
        }
    }, 
    computed: {
        computedObjClass: function() {
            return {
                active: this.isActive,
                disable: this.isDisable
            }
        }

    }
});