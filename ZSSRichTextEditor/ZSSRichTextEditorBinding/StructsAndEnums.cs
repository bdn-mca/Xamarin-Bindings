using System;

namespace ZSSRichTextEditorBinding
{
    public enum HCPCSaveStyle : uint
    {
        lways,
        ndCancel
    }

    public static class ToolbarOptions
    {
        public const string ZSSRichTextEditorToolbarBold = "com.zedsaid.toolbaritem.bold";
        public const string ZSSRichTextEditorToolbarItalic = @"com.zedsaid.toolbaritem.italic";
        public const string ZSSRichTextEditorToolbarSubscript = @"com.zedsaid.toolbaritem.subscript";
        public const string ZSSRichTextEditorToolbarSuperscript = @"com.zedsaid.toolbaritem.superscript";
        public const string ZSSRichTextEditorToolbarStrikeThrough = @"com.zedsaid.toolbaritem.strikeThrough";
        public const string ZSSRichTextEditorToolbarUnderline = @"com.zedsaid.toolbaritem.underline";
        public const string ZSSRichTextEditorToolbarRemoveFormat = @"com.zedsaid.toolbaritem.removeFormat";
        public const string ZSSRichTextEditorToolbarJustifyLeft = @"com.zedsaid.toolbaritem.justifyLeft";
        public const string ZSSRichTextEditorToolbarJustifyCenter = @"com.zedsaid.toolbaritem.justifyCenter";
        public const string ZSSRichTextEditorToolbarJustifyRight = @"com.zedsaid.toolbaritem.justifyRight";
        public const string ZSSRichTextEditorToolbarJustifyFull = @"com.zedsaid.toolbaritem.justifyFull";
        public const string ZSSRichTextEditorToolbarH1 = @"com.zedsaid.toolbaritem.h1";
        public const string ZSSRichTextEditorToolbarH2 = @"com.zedsaid.toolbaritem.h2";
        public const string ZSSRichTextEditorToolbarH3 = @"com.zedsaid.toolbaritem.h3";
        public const string ZSSRichTextEditorToolbarH4 = @"com.zedsaid.toolbaritem.h4";
        public const string ZSSRichTextEditorToolbarH5 = @"com.zedsaid.toolbaritem.h5";
        public const string ZSSRichTextEditorToolbarH6 = @"com.zedsaid.toolbaritem.h6";
        public const string ZSSRichTextEditorToolbarTextColor = @"com.zedsaid.toolbaritem.textColor";
        public const string ZSSRichTextEditorToolbarBackgroundColor = @"com.zedsaid.toolbaritem.backgroundColor";
        public const string ZSSRichTextEditorToolbarUnorderedList = @"com.zedsaid.toolbaritem.unorderedList";
        public const string ZSSRichTextEditorToolbarOrderedList = @"com.zedsaid.toolbaritem.orderedList";
        public const string ZSSRichTextEditorToolbarHorizontalRule = @"com.zedsaid.toolbaritem.horizontalRule";
        public const string ZSSRichTextEditorToolbarIndent = @"com.zedsaid.toolbaritem.indent";
        public const string ZSSRichTextEditorToolbarOutdent = @"com.zedsaid.toolbaritem.outdent";
        public const string ZSSRichTextEditorToolbarInsertImage = @"com.zedsaid.toolbaritem.insertImage";
        public const string ZSSRichTextEditorToolbarInsertLink = @"com.zedsaid.toolbaritem.insertLink";
        public const string ZSSRichTextEditorToolbarRemoveLink = @"com.zedsaid.toolbaritem.removeLink";
        public const string ZSSRichTextEditorToolbarQuickLink = @"com.zedsaid.toolbaritem.quickLink";
        public const string ZSSRichTextEditorToolbarUndo = @"com.zedsaid.toolbaritem.undo";
        public const string ZSSRichTextEditorToolbarRedo = @"com.zedsaid.toolbaritem.redo";
        public const string ZSSRichTextEditorToolbarViewSource = @"com.zedsaid.toolbaritem.viewSource";
        public const string ZSSRichTextEditorToolbarParagraph = @"com.zedsaid.toolbaritem.paragraph";
        public const string ZSSRichTextEditorToolbarAll = @"com.zedsaid.toolbaritem.all";
        public const string ZSSRichTextEditorToolbarNone = @"com.zedsaid.toolbaritem.none";
    }
}