var plugin = {
    Loaded : function()
    {
        CheckLoad();
    }
};

mergeInto(LibraryManager.library, plugin);