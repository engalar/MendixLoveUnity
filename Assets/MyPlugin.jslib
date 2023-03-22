mergeInto(LibraryManager.library, {
  ClickObject: function (name, score) {
    window.dispatchReactUnityEvent("ClickObject", UTF8ToString(name), score);
  },
  GameOver: function (userName, score) {
    window.dispatchReactUnityEvent("GameOver", UTF8ToString(userName), score);
  },
});