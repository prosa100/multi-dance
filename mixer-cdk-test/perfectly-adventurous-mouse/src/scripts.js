window.addEventListener('load', function initMixer() {
  // Move the video by a static offset amount
  const offset = 50;

  console.log("hello");
mixer.display.on("onplaying", console.log);
mixer.display.on("timeupdate", console.log);

  mixer.display.moveVideo({
    top: offset,
    bottom: offset,
    left: offset,
    right: offset,
  });

  // Whenever someone clicks on "Hello World", we'll send an event
  // to the game client on the control ID "hello-world"
  document.getElementById('hello-world').onclick = function(event) {
    mixer.socket.call('giveInput', {
      controlID: 'my_first_button',
      event: 'click',
      button: event.button,
    });
  };

  mixer.isLoaded();
});
