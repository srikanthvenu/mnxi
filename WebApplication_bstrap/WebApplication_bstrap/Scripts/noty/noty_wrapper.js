function notyMsg(msg) {

    $.noty.defaults = {
        layout: 'center',
        theme: 'defaultTheme',
        dismissQueue: true,
        maxVisible: 5,
        template: '<div class="noty_message"><span class="noty_text"></span><div class="noty_close"></div></div>',
        animation: {
            open: { height: 'toggle', opacity: '1' },
            close: { height: 'toggle', opacity: '0.1' },
            easing: 'linear',
            speed: 500
        },
        timeout: false,
        force: false,
        modal: false,
        closeWith: ['click'],
        callback: {
            onShow: function () { },
            afterShow: function () { },
            onClose: function () { },
            afterClose: function () { }
        }
    };
    var n = noty({
        text: msg,
        type: 'alert',
        buttons: true
    });

}