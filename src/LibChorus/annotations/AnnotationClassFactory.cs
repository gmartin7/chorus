using System;
using System.Windows.Forms;

namespace Chorus.annotations
{
	public static class AnnotationClassFactory
	{
		public static ImageList CreateImageListContainingAnnotationImages()
		{
			var list = new ImageList();
			list.ColorDepth=ColorDepth.Depth32Bit;
			list.Images.Add("question", Chorus.Properties.AnnotationImages.question16x16);
			list.Images.Add("questionClosed", Chorus.Properties.AnnotationImages.question16x16Closed);
			list.Images.Add("mergeconflict", Chorus.Properties.AnnotationImages.MergeConflict16x16);
			list.Images.Add("mergeconflictClosed", Chorus.Properties.AnnotationImages.MergeConflict16x16Closed);
			list.Images.Add("note", Chorus.Properties.AnnotationImages.note16x16);
			list.Images.Add("noteClosed", Chorus.Properties.AnnotationImages.note16x16);
			return list;
		}

		public static AnnotationClass GetClassOrDefault(string name)
		{
			switch (name.ToLower())
			{
				case "question":
					return new QuestionAnnotationClass();
				case "note":
					return new NoteAnnotationClass();
				case "mergeconflict":
					return new ConflictAnnotationClass();
				default:
					return new AnnotationClass(name);
			}
		}
	}
}