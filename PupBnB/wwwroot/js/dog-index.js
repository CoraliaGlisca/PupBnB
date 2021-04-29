(function ($) {
    function Dog() {
        var $this = this;

        function initializeModel() {
            $("#modal-action-dog").on('loaded.bs.modal', function (e) {
            }).on('hidden.bs.modal', function (e) {
                $(this).removeData('bs.modal');
            });
        }
        $this.init = function () {
            initializeModel();
        }
    }
    $(function () {
        var dog = new Dog();
        dog.init();
    })
}(jQuery)) 