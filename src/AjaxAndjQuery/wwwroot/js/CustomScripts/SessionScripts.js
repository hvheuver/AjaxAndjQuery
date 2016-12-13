var sessionView = {
    init: function() {
        $("#formAdd").submit(function () {
            $.post(this.action,$(this).serialize(),function (data) {
                    $("#sessionList").html(data);
                    $("#Name").val("");
                    $("#Description").val("");
                    $("#Level").val("--Select a level--");
                 //eventhandling bij klik op remove button
                    $(".formRemove").submit(function () {
                            $.post(this.action,$(this).serialize(),function (data2) {
                                    $("#sessionList").html(data2);
                            });
                        return false;
                    });
                });
            return false;  //formulier wordt niet gesubmit
        });

    }
};

$(function () {
    sessionView.init();
});



