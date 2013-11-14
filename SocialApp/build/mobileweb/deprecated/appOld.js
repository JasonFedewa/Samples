// this sets the background color of the master UIView (when there are no windows/tab groups on it)
Titanium.UI.setBackgroundColor('#000');
Ti.include('birdhouse.js');

var win1 = Titanium.UI.createWindow({  
    title:'Tab 1',
    backgroundImage: 'images/background.jpg'
});

var label = Titanium.UI.createLabel({
    width:  280,
    height: 'auto',
    top: 20,
    left: 20,
    color: '#fff',
    font: {fontSize: 18, fontFamily: 'Helvetica', fontWeight: 'bold'},
    text: 'Chatter Box'
});
win1.add(label);

var txtTitle = Titanium.UI.createTextField({
    width: 160,
    height: 35,
    left: 140,
    top: 90,
    value: 'Message title...',
    borderStyle: 2,
    backgroundColor: '#fff'
});
win1.add(txtTitle);

var txtMessage = Titanium.UI.createTextArea({
    width: 160,
    height: 120,
    left: 140,
    top: 130,
    value: 'Message text...',
    font: {fontSize: 15},
    borderStyle: 2,
    backgroundColor: '#fff'
});
win1.add(txtMessage);

//create your email
function postToEmail() {
    var emailDialog = Titanium.UI.createEmailDialog();
    emailDialog.subject = txtTitle.value;
    emailDialog.toRecipients = ['info@packtpub.com'];
    emailDialog.messageBody = txtMessage.value;
    emailDialog.open();    
}

var buttonEmail = Titanium.UI.createButton({
    width:  280,
    height:  35,
    top: 280,
    left: 20,
    title: 'Send Via Email'
});

buttonEmail.addEventListener('click', function(e){
  if(txtMessage.value != null) {
    postToEmail();    
 } else {
    alert('You must enter a message!');
 }
});

win1.add(buttonEmail);

/*function randomString(length, current) {
	current = current ? current : '';
	return length ? randomString(--length, "abcdefghiklmnopqrstuvwxyz".charAt(Math.floor(Math.random() * 60)) + current) : current;
}*/

//create your twitter session and post a tweet
function postToTwitter()
{
   var BH = new BirdHouse({
    consumer_key: "t0ytVJI1nc4k5br8Krab7A",
    consumer_secret: "fQ6m2Ygv7b9WhOXoBoXPEfjNciFB6yd1VYvuSbnc"
   });
   //call the birdhouse authorize() method
   BH.authorize();
}

var buttonTwitter = Titanium.UI.createButton({
    width:  280,
    height:  35,
    top: 360,
    left: 20,
    title: 'Send Via Twitter'
});
buttonTwitter.addEventListener('click', function(e){
 if(txtMessage.value != null) {
    postToTwitter();
 } else {
    alert('You must enter a message!');
 }
});
win1.add(buttonTwitter);

win1.open();