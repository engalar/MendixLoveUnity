mergeInto(LibraryManager.library, {
  ClickObject: function (name, score) {
    ReactUnityWebGL.ClickObject(Pointer_stringify(name), score);
  },
  GameOver: function (userName, score) {
    ReactUnityWebGL.GameOver(Pointer_stringify(userName), score);
  },
});