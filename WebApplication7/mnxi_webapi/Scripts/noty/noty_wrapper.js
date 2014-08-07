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
        buttons: false
    });

}

function notymodal(msg) {
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

    noty({
        text: msg,
        buttons: [
          {
              addClass: 'btn btn-primary', text: 'Ok', onClick: function ($noty) {

                  // this = button element
                  // $noty = $noty element

                  $noty.close();
                  // noty({ text: 'You clicked "Ok" button', type: 'success' });
              }
          },
          {
              addClass: 'btn btn-danger', text: 'Cancel', onClick: function ($noty) {
                  $noty.close();
                  // noty({ text: 'You clicked "Cancel" button', type: 'error' });
              }
          }
        ]
    });




}


function notyInfo(msg) {
    $.noty.defaults = {
        layout: 'center',
        type: 'information',
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

    noty({
        text: msg,
        buttons: [
          {
              addClass: 'btn btn-primary', text: 'Ok', onClick: function ($noty) {

                  // this = button element
                  // $noty = $noty element

                  $noty.close();
                  // noty({ text: 'You clicked "Ok" button', type: 'success' });
              }
          }

        ]
    });




}