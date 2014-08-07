<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication_bstrap.About" %>


 
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="css/datepicker.css">
        <link rel="stylesheet" href="css/bootstrap.css">
    <link href="Content/datepicker3.css" rel="stylesheet" />
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
     <div class="container">
           <span class="input-group date span3 col-md-3"  >
  <input type="text" class="form-control"><span class="input-group-addon">
      <i class="glyphicon glyphicon-th"></i></span>
</span>
         <p></p>
         <button id="btn"  class="button"> display Date</button>
           <button id="btn2"  class="button"> display Date</button>
         notymodal
        </div>
        <!-- Load jQuery and bootstrap datepicker scripts -->
         <script src="Scripts/jquery-1.10.2.js"></script>
          <script src="Scripts/bootstrpdatepicker/bootstrap-datepicker.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/noty/jquery.noty.js"></script>
    <script src="Scripts/noty/layouts/topCenter.js"></script>
    <script src="Scripts/noty/themes/default.js"></script>
    <script src="Scripts/noty/layouts/center.js"></script>
    
        <script type="text/javascript">
            // When the document is ready
            $(document).ready(function () {

                $('#generateNoty').click(function () {
                    $.noty.defaults = {
                        layout: 'topCenter',
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
                        text: 'Noty + Bitconfig = Fun !!',
                        type: 'alert',
                        buttons: false
                    });
                });


                $('.date').datepicker({
                    weekStart: 2,
                    startDate: "01/10/2013",
                    format: 'mm/dd/yyyy',

                    forceParse: false,
                    autoclose: true
                });
                $("#btn").click(function () {

                    var nowTemp = $('.date').datepicker('getDate');
                    n = nowTemp.getDate();
                    {
                        var now =  + nowTemp.getMonth().toString() +'/'+ nowTemp.getDate().toString()+'/' +nowTemp.getFullYear().toString();
                        notyMsg(now);
                    }

                    return false;
                });

                $("#btn2").click(function () {

                    var nowTemp = $('.date').datepicker('getDate');
                    n = nowTemp.getDate();
                    {
                        var now = +nowTemp.getMonth().toString() + '/' + nowTemp.getDate().toString() + '/' + nowTemp.getFullYear().toString();
                        notymodal(now);
                    }

                    return false;
                });

            });

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
                    text: 'Do you want to continue?',
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
        </script>
      <br />

     

    <div id="srch" class="srch  span5" " style="background-color:darkgrey">
      
         
 <div class="col-md-3"> 
           
              <span class="input-group date col-md-3 span5  "  style="float:left" >
                   <label for="srvFrmdate"  class=" col-md-4">From</label>
            <input type="text" name="srvFrmdate" id="srvFrmdate" class="input-group date ui-widget-content ui-corner-all date" />
              <span class="input-group-addon">                
      <i class="glyphicon glyphicon-th"></i></span> 

              </span>
     </div>
         <div class="col-md-3"> 
              <span class="input-group date col-md-3 span5  "  style="float:left">
                  <label for="srvTOdate" class=" col-md-4">TO Date</label>
            <input type="text" name="srvTOdate" id="srvTOdate"  class="input-group date ui-widget-content ui-corner-all date" />
<span class="input-group-addon" style=" height:21px">                
      <i class="glyphicon glyphicon-th"></i></span> 
              </span>
             </div>
              <div class="col-md-3"> 
            <span class="col-md-5 span5" >
                 <label for="CatName">Category</label>
            <input type="text" name="CatName" id="CatName" class="ui-widget-content ui-corner-all" />
            </span>
                  </div>

                   <div class="col-md-3"> 
           <span class="col-md-2 span5" >

          
            <label for="SrvName">Service Name</label>
            <input type="text" name="SrvName" id="SrvName" class="ui-widget-content ui-corner-all" />
          
               </span>
                       </div>
        
             <input type="button" id="getresults" value="Search"/>



            <!-- Allow form submission with keyboard without duplicating the dialog button 
      <input type="submit" tabindex="-1" style="position:absolute; top:-1000px">-->



       

    </div>

    <div>

         <div class="col-md-3">
                <span class="input-group date "  style="float:left">
                  <label for="srvTOdate" class=" col-md-4">TO Date</label>
            <input type="text" name="srvTOdate" id="srvTOdate"  class="input-group date ui-widget-content ui-corner-all date" />
          <span class="input-group-addon" style=" height:21px">                
      <i class="glyphicon glyphicon-th"></i></span> 

         </div>

        
         <div class="col-md-3">
             <span  class="input-group date "  >
                 <label for="CatName">Category</label>
            <input type="text" name="CatName" id="CatName" class="ui-widget-content ui-corner-all" />
            </span>
         </div>
        
         <div class="col-md-3">

         </div>
        
         <div class="col-md-3">

         </div>
    </div>

</asp:Content>
