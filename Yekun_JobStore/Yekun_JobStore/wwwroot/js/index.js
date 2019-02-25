 function responsiveNav() {
     var x = document.getElementById("menus");

     if (x.className === "menu") {
         x.className += " responsive";

     } else {
         x.className = "menu";
     }
 }

 window.onscroll = function() { fixedNav() };
 var x = document.getElementById("menus");
 var navbar = document.getElementById("nav-bar");
 var contact = document.getElementById("contact");
 var sticky = navbar.offsetTop;

 function fixedNav() {
     if (window.pageYOffset >= sticky) {
         navbar.classList.add("sticky");

     } else {
         navbar.classList.remove("sticky");

     }
 }
 //  $(document).ready(function() {
 //      $('.js-example-disabled-results').select2({
 //          tags: "true",
 //          placeholder: "Select an option",
 //          allowClear: true,
 //          theme: "classic",
 //          width: '320px'

 //      });

 //  });

 $('.js-example-disabled-reoisults').on('select2:opening select2:closing', function(event) {
     var $searchfield = $(this).parent().find('.select2-search__field');
     $searchfield.prop('disabled', true);
 });




 function changelText() {
     document.getElementById('txt').innerHTML = 'En cox baxilan is elanlari';
     document.getElementById('looking').style.backgroundColor = '#555';
     document.getElementById('looking').style.color = '#fff';
     document.getElementById('new').style.backgroundColor = '#ebeeef'
     document.getElementById('new').style.color = 'black';
 }

 function changenText() {
     document.getElementById('txt').innerHTML = 'En yeni is elanlari';
     document.getElementById('new').style.backgroundColor = '#555';
     document.getElementById('new').style.color = '#fff';
     document.getElementById('looking').style.backgroundColor = '#ebeeef'
     document.getElementById('looking').style.color = 'black';
 }
 (function(d, s, id) {
     var js, fjs = d.getElementsByTagName(s)[0];
     if (d.getElementById(id)) return;
     js = d.createElement(s);
     js.id = id;
     js.src = 'https://connect.facebook.net/en_US/sdk.js#xfbml=1&version=v3.2';
     fjs.parentNode.insertBefore(js, fjs);
 }(document, 'script', 'facebook-jssdk'));

 //  $('.anc-cont').css({
 //      'background-position': '70% ' + (-scrollPos / 16) + "px"
 //  });

 (function($) {
     function floatLabel(inputType) {
         $(inputType).each(function() {
             var $this = $(this);
             // on focus add cladd active to label
             $this.focus(function() {
                 $this.next().addClass("active");
             });
             //on blur check field and remove class if needed
             $this.blur(function() {
                 if ($this.val() === '' || $this.val() === 'blank') {
                     $this.next().removeClass();
                 }
             });
         });
     }
     // just add a class of "floatLabel to the input field!"
     floatLabel(".floatLabel");
})(jQuery);

$('.message a').click(function () {
    $('form').animate({ height: "toggle", opacity: "toggle" }, "slow");
});