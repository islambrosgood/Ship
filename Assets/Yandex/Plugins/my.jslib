mergeInto(LibraryManager.library, {

  ShowAdv: function () {
	ysdk.adv.showFullscreenAdv({
    callbacks: {
        onClose: function(wasShown) {
          console.log("Реклама показана!");
		  
		  window.unityInstance.SendMessage("Showads", "UnMuteAudio");

          console.log("Реклама закрыта!");
        }
	}	
	})

   },
});