using DocumentFormat.OpenXml.Packaging;
using Ap = DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using W14 = DocumentFormat.OpenXml.Office2010.Word;
using M = DocumentFormat.OpenXml.Math;
using Ovml = DocumentFormat.OpenXml.Vml.Office;
using V = DocumentFormat.OpenXml.Vml;
using W15 = DocumentFormat.OpenXml.Office2013.Word;
using A = DocumentFormat.OpenXml.Drawing;
using Thm15 = DocumentFormat.OpenXml.Office2013.Theme;

namespace ORM.Test.Reporting
{
    public class Report
    {
        public string DataName { get; set; } = "Имя123";

        public string DataValue { get; set; } = "Значение123";

        public string DataV3 { get; set; } = "V31";




        // Creates a WordprocessingDocument.
        public void CreatePackage(string filePath)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                CreateParts(package);
            }
        }

        // Adds child parts and generates content of the specified part.
        private void CreateParts(WordprocessingDocument document)
        {
            ExtendedFilePropertiesPart extendedFilePropertiesPart1 = document.AddNewPart<ExtendedFilePropertiesPart>("rId3");
            GenerateExtendedFilePropertiesPart1Content(extendedFilePropertiesPart1);

            MainDocumentPart mainDocumentPart1 = document.AddMainDocumentPart();
            GenerateMainDocumentPart1Content(mainDocumentPart1);

            WebSettingsPart webSettingsPart1 = mainDocumentPart1.AddNewPart<WebSettingsPart>("rId3");
            GenerateWebSettingsPart1Content(webSettingsPart1);

            DocumentSettingsPart documentSettingsPart1 = mainDocumentPart1.AddNewPart<DocumentSettingsPart>("rId2");
            GenerateDocumentSettingsPart1Content(documentSettingsPart1);

            StyleDefinitionsPart styleDefinitionsPart1 = mainDocumentPart1.AddNewPart<StyleDefinitionsPart>("rId1");
            GenerateStyleDefinitionsPart1Content(styleDefinitionsPart1);

            ThemePart themePart1 = mainDocumentPart1.AddNewPart<ThemePart>("rId5");
            GenerateThemePart1Content(themePart1);

            FontTablePart fontTablePart1 = mainDocumentPart1.AddNewPart<FontTablePart>("rId4");
            GenerateFontTablePart1Content(fontTablePart1);

            SetPackageProperties(document);
        }

        // Generates content of extendedFilePropertiesPart1.
        private void GenerateExtendedFilePropertiesPart1Content(ExtendedFilePropertiesPart extendedFilePropertiesPart1)
        {
            Ap.Properties properties1 = new Ap.Properties();
            properties1.AddNamespaceDeclaration("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");
            Ap.Template template1 = new Ap.Template();
            template1.Text = "Normal.dotm";
            Ap.TotalTime totalTime1 = new Ap.TotalTime();
            totalTime1.Text = "2";
            Ap.Pages pages1 = new Ap.Pages();
            pages1.Text = "1";
            Ap.Words words1 = new Ap.Words();
            words1.Text = "5";
            Ap.Characters characters1 = new Ap.Characters();
            characters1.Text = "30";
            Ap.Application application1 = new Ap.Application();
            application1.Text = "Microsoft Office Word";
            Ap.DocumentSecurity documentSecurity1 = new Ap.DocumentSecurity();
            documentSecurity1.Text = "0";
            Ap.Lines lines1 = new Ap.Lines();
            lines1.Text = "1";
            Ap.Paragraphs paragraphs1 = new Ap.Paragraphs();
            paragraphs1.Text = "1";
            Ap.ScaleCrop scaleCrop1 = new Ap.ScaleCrop();
            scaleCrop1.Text = "false";
            Ap.Company company1 = new Ap.Company();
            company1.Text = "";
            Ap.LinksUpToDate linksUpToDate1 = new Ap.LinksUpToDate();
            linksUpToDate1.Text = "false";
            Ap.CharactersWithSpaces charactersWithSpaces1 = new Ap.CharactersWithSpaces();
            charactersWithSpaces1.Text = "34";
            Ap.SharedDocument sharedDocument1 = new Ap.SharedDocument();
            sharedDocument1.Text = "false";
            Ap.HyperlinksChanged hyperlinksChanged1 = new Ap.HyperlinksChanged();
            hyperlinksChanged1.Text = "false";
            Ap.ApplicationVersion applicationVersion1 = new Ap.ApplicationVersion();
            applicationVersion1.Text = "16.0000";

            properties1.Append(template1);
            properties1.Append(totalTime1);
            properties1.Append(pages1);
            properties1.Append(words1);
            properties1.Append(characters1);
            properties1.Append(application1);
            properties1.Append(documentSecurity1);
            properties1.Append(lines1);
            properties1.Append(paragraphs1);
            properties1.Append(scaleCrop1);
            properties1.Append(company1);
            properties1.Append(linksUpToDate1);
            properties1.Append(charactersWithSpaces1);
            properties1.Append(sharedDocument1);
            properties1.Append(hyperlinksChanged1);
            properties1.Append(applicationVersion1);

            extendedFilePropertiesPart1.Properties = properties1;
        }

        // Generates content of mainDocumentPart1.
        private void GenerateMainDocumentPart1Content(MainDocumentPart mainDocumentPart1)
        {
            Document document1 = new Document() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 w15 w16se w16cid wp14" } };
            document1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            document1.AddNamespaceDeclaration("cx", "http://schemas.microsoft.com/office/drawing/2014/chartex");
            document1.AddNamespaceDeclaration("cx1", "http://schemas.microsoft.com/office/drawing/2015/9/8/chartex");
            document1.AddNamespaceDeclaration("cx2", "http://schemas.microsoft.com/office/drawing/2015/10/21/chartex");
            document1.AddNamespaceDeclaration("cx3", "http://schemas.microsoft.com/office/drawing/2016/5/9/chartex");
            document1.AddNamespaceDeclaration("cx4", "http://schemas.microsoft.com/office/drawing/2016/5/10/chartex");
            document1.AddNamespaceDeclaration("cx5", "http://schemas.microsoft.com/office/drawing/2016/5/11/chartex");
            document1.AddNamespaceDeclaration("cx6", "http://schemas.microsoft.com/office/drawing/2016/5/12/chartex");
            document1.AddNamespaceDeclaration("cx7", "http://schemas.microsoft.com/office/drawing/2016/5/13/chartex");
            document1.AddNamespaceDeclaration("cx8", "http://schemas.microsoft.com/office/drawing/2016/5/14/chartex");
            document1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            document1.AddNamespaceDeclaration("aink", "http://schemas.microsoft.com/office/drawing/2016/ink");
            document1.AddNamespaceDeclaration("am3d", "http://schemas.microsoft.com/office/drawing/2017/model3d");
            document1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            document1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            document1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            document1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            document1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            document1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            document1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            document1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            document1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            document1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");
            document1.AddNamespaceDeclaration("w16cid", "http://schemas.microsoft.com/office/word/2016/wordml/cid");
            document1.AddNamespaceDeclaration("w16se", "http://schemas.microsoft.com/office/word/2015/wordml/symex");
            document1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            document1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            document1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            document1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            Body body1 = new Body();

            Paragraph paragraph1 = new Paragraph() { RsidParagraphAddition = "00732A61", RsidParagraphProperties = "00827FBB", RsidRunAdditionDefault = "00827FBB", ParagraphId = "6B82428B", TextId = "0593D603" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId1 = new ParagraphStyleId() { Val = "a3" };

            paragraphProperties1.Append(paragraphStyleId1);

            Run run1 = new Run() { RsidRunProperties = "00827FBB" };

            RunProperties runProperties1 = new RunProperties();
            Bold bold1 = new Bold();
            Color color1 = new Color() { Val = "262626", ThemeColor = ThemeColorValues.Text1, ThemeTint = "D9" };
            Spacing spacing1 = new Spacing() { Val = 0 };
            FontSize fontSize1 = new FontSize() { Val = "180" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript() { Val = "180" };
            Highlight highlight1 = new Highlight() { Val = HighlightColorValues.Yellow };

            W14.Shadow shadow1 = new W14.Shadow() { BlurRadius = 0L, DistanceFromText = 38100L, DirectionAngle = 2700000, HorizontalScalingFactor = 100000, VerticalScalingFactor = 100000, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.BottomLeft };
            W14.SchemeColor schemeColor1 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor5 };

            shadow1.Append(schemeColor1);

            W14.TextOutlineEffect textOutlineEffect1 = new W14.TextOutlineEffect() { LineWidth = 6731, CapType = W14.LineCapValues.Flat, Compound = W14.CompoundLineValues.Simple, Alignment = W14.PenAlignmentValues.Center };

            W14.SolidColorFillProperties solidColorFillProperties1 = new W14.SolidColorFillProperties();
            W14.SchemeColor schemeColor2 = new W14.SchemeColor() { Val = W14.SchemeColorValues.BackgroundColor };

            solidColorFillProperties1.Append(schemeColor2);
            W14.PresetLineDashProperties presetLineDashProperties1 = new W14.PresetLineDashProperties() { Val = W14.PresetLineDashValues.Solid };
            W14.RoundEmpty roundEmpty1 = new W14.RoundEmpty();

            textOutlineEffect1.Append(solidColorFillProperties1);
            textOutlineEffect1.Append(presetLineDashProperties1);
            textOutlineEffect1.Append(roundEmpty1);

            runProperties1.Append(bold1);
            runProperties1.Append(color1);
            runProperties1.Append(spacing1);
            runProperties1.Append(fontSize1);
            runProperties1.Append(fontSizeComplexScript1);
            runProperties1.Append(highlight1);
            runProperties1.Append(shadow1);
            runProperties1.Append(textOutlineEffect1);
            Text text1 = new Text();
            text1.Text = DataName;

            run1.Append(runProperties1);
            run1.Append(text1);
            BookmarkStart bookmarkStart1 = new BookmarkStart() { Name = "_GoBack", Id = "0" };
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd() { Id = "0" };

            paragraph1.Append(paragraphProperties1);
            paragraph1.Append(run1);
            paragraph1.Append(bookmarkStart1);
            paragraph1.Append(bookmarkEnd1);

            Paragraph paragraph2 = new Paragraph() { RsidParagraphAddition = "00827FBB", RsidRunAdditionDefault = "00827FBB", ParagraphId = "1385DA87", TextId = "54FDF59F" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties1 = new ParagraphMarkRunProperties();
            Bold bold2 = new Bold();
            Outline outline1 = new Outline();
            Color color2 = new Color() { Val = "ED7D31", ThemeColor = ThemeColorValues.Accent2 };
            FontSize fontSize2 = new FontSize() { Val = "144" };
            FontSizeComplexScript fontSizeComplexScript2 = new FontSizeComplexScript() { Val = "144" };

            W14.Shadow shadow2 = new W14.Shadow() { BlurRadius = 0L, DistanceFromText = 38100L, DirectionAngle = 2700000, HorizontalScalingFactor = 100000, VerticalScalingFactor = 100000, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.TopLeft };
            W14.SchemeColor schemeColor3 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            shadow2.Append(schemeColor3);

            W14.TextOutlineEffect textOutlineEffect2 = new W14.TextOutlineEffect() { LineWidth = 6604, CapType = W14.LineCapValues.Flat, Compound = W14.CompoundLineValues.Simple, Alignment = W14.PenAlignmentValues.Center };

            W14.SolidColorFillProperties solidColorFillProperties2 = new W14.SolidColorFillProperties();
            W14.SchemeColor schemeColor4 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            solidColorFillProperties2.Append(schemeColor4);
            W14.PresetLineDashProperties presetLineDashProperties2 = new W14.PresetLineDashProperties() { Val = W14.PresetLineDashValues.Solid };
            W14.RoundEmpty roundEmpty2 = new W14.RoundEmpty();

            textOutlineEffect2.Append(solidColorFillProperties2);
            textOutlineEffect2.Append(presetLineDashProperties2);
            textOutlineEffect2.Append(roundEmpty2);

            W14.FillTextEffect fillTextEffect1 = new W14.FillTextEffect();

            W14.SolidColorFillProperties solidColorFillProperties3 = new W14.SolidColorFillProperties();
            W14.RgbColorModelHex rgbColorModelHex1 = new W14.RgbColorModelHex() { Val = "FFFFFF" };

            solidColorFillProperties3.Append(rgbColorModelHex1);

            fillTextEffect1.Append(solidColorFillProperties3);

            paragraphMarkRunProperties1.Append(bold2);
            paragraphMarkRunProperties1.Append(outline1);
            paragraphMarkRunProperties1.Append(color2);
            paragraphMarkRunProperties1.Append(fontSize2);
            paragraphMarkRunProperties1.Append(fontSizeComplexScript2);
            paragraphMarkRunProperties1.Append(shadow2);
            paragraphMarkRunProperties1.Append(textOutlineEffect2);
            paragraphMarkRunProperties1.Append(fillTextEffect1);

            paragraphProperties2.Append(paragraphMarkRunProperties1);

            Run run2 = new Run() { RsidRunProperties = "00827FBB" };

            RunProperties runProperties2 = new RunProperties();
            Bold bold3 = new Bold();
            Outline outline2 = new Outline();
            Color color3 = new Color() { Val = "ED7D31", ThemeColor = ThemeColorValues.Accent2 };
            FontSize fontSize3 = new FontSize() { Val = "144" };
            FontSizeComplexScript fontSizeComplexScript3 = new FontSizeComplexScript() { Val = "144" };

            W14.Shadow shadow3 = new W14.Shadow() { BlurRadius = 0L, DistanceFromText = 38100L, DirectionAngle = 2700000, HorizontalScalingFactor = 100000, VerticalScalingFactor = 100000, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.TopLeft };
            W14.SchemeColor schemeColor5 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            shadow3.Append(schemeColor5);

            W14.TextOutlineEffect textOutlineEffect3 = new W14.TextOutlineEffect() { LineWidth = 6604, CapType = W14.LineCapValues.Flat, Compound = W14.CompoundLineValues.Simple, Alignment = W14.PenAlignmentValues.Center };

            W14.SolidColorFillProperties solidColorFillProperties4 = new W14.SolidColorFillProperties();
            W14.SchemeColor schemeColor6 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            solidColorFillProperties4.Append(schemeColor6);
            W14.PresetLineDashProperties presetLineDashProperties3 = new W14.PresetLineDashProperties() { Val = W14.PresetLineDashValues.Solid };
            W14.RoundEmpty roundEmpty3 = new W14.RoundEmpty();

            textOutlineEffect3.Append(solidColorFillProperties4);
            textOutlineEffect3.Append(presetLineDashProperties3);
            textOutlineEffect3.Append(roundEmpty3);

            W14.FillTextEffect fillTextEffect2 = new W14.FillTextEffect();

            W14.SolidColorFillProperties solidColorFillProperties5 = new W14.SolidColorFillProperties();
            W14.RgbColorModelHex rgbColorModelHex2 = new W14.RgbColorModelHex() { Val = "FFFFFF" };

            solidColorFillProperties5.Append(rgbColorModelHex2);

            fillTextEffect2.Append(solidColorFillProperties5);

            runProperties2.Append(bold3);
            runProperties2.Append(outline2);
            runProperties2.Append(color3);
            runProperties2.Append(fontSize3);
            runProperties2.Append(fontSizeComplexScript3);
            runProperties2.Append(shadow3);
            runProperties2.Append(textOutlineEffect3);
            runProperties2.Append(fillTextEffect2);
            Text text2 = new Text();
            text2.Text = DataValue;

            run2.Append(runProperties2);
            run2.Append(text2);

            paragraph2.Append(paragraphProperties2);
            paragraph2.Append(run2);

            Table table1 = new Table();

            TableProperties tableProperties1 = new TableProperties();
            TableStyle tableStyle1 = new TableStyle() { Val = "a5" };
            TableWidth tableWidth1 = new TableWidth() { Width = "0", Type = TableWidthUnitValues.Auto };
            TableLook tableLook1 = new TableLook() { Val = "04A0" };

            tableProperties1.Append(tableStyle1);
            tableProperties1.Append(tableWidth1);
            tableProperties1.Append(tableLook1);

            TableGrid tableGrid1 = new TableGrid();
            GridColumn gridColumn1 = new GridColumn() { Width = "2336" };
            GridColumn gridColumn2 = new GridColumn() { Width = "2336" };
            GridColumn gridColumn3 = new GridColumn() { Width = "2336" };
            GridColumn gridColumn4 = new GridColumn() { Width = "2337" };

            tableGrid1.Append(gridColumn1);
            tableGrid1.Append(gridColumn2);
            tableGrid1.Append(gridColumn3);
            tableGrid1.Append(gridColumn4);

            TableRow tableRow1 = new TableRow() { RsidTableRowAddition = "00827FBB", RsidTableRowProperties = "00827FBB", ParagraphId = "7DC9FD98", TextId = "77777777" };

            TableCell tableCell1 = new TableCell();

            TableCellProperties tableCellProperties1 = new TableCellProperties();
            TableCellWidth tableCellWidth1 = new TableCellWidth() { Width = "2336", Type = TableWidthUnitValues.Dxa };

            tableCellProperties1.Append(tableCellWidth1);

            Paragraph paragraph3 = new Paragraph() { RsidParagraphMarkRevision = "00827FBB", RsidParagraphAddition = "00827FBB", RsidRunAdditionDefault = "00827FBB", ParagraphId = "61C41022", TextId = "2673DA22" };

            ParagraphProperties paragraphProperties3 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties2 = new ParagraphMarkRunProperties();
            Bold bold4 = new Bold();
            Outline outline3 = new Outline();
            Color color4 = new Color() { Val = "ED7D31", ThemeColor = ThemeColorValues.Accent2 };
            FontSize fontSize4 = new FontSize() { Val = "144" };
            FontSizeComplexScript fontSizeComplexScript4 = new FontSizeComplexScript() { Val = "144" };
            Languages languages1 = new Languages() { Val = "en-US" };

            W14.Shadow shadow4 = new W14.Shadow() { BlurRadius = 63500L, DistanceFromText = 50800L, DirectionAngle = 0, HorizontalScalingFactor = 0, VerticalScalingFactor = 0, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.None };

            W14.RgbColorModelHex rgbColorModelHex3 = new W14.RgbColorModelHex() { Val = "000000" };
            W14.Alpha alpha1 = new W14.Alpha() { Val = 50000 };

            rgbColorModelHex3.Append(alpha1);

            shadow4.Append(rgbColorModelHex3);
            W14.Reflection reflection1 = new W14.Reflection() { BlurRadius = 6350L, StartingOpacity = 55000, StartPosition = 0, EndingOpacity = 300, EndPosition = 45500, DistanceFromText = 0L, DirectionAngle = 5400000, FadeDirection = 5400000, HorizontalScalingFactor = 100000, VerticalScalingFactor = -100000, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.BottomLeft };

            W14.TextOutlineEffect textOutlineEffect4 = new W14.TextOutlineEffect() { LineWidth = 6604, CapType = W14.LineCapValues.Flat, Compound = W14.CompoundLineValues.Simple, Alignment = W14.PenAlignmentValues.Center };

            W14.SolidColorFillProperties solidColorFillProperties6 = new W14.SolidColorFillProperties();
            W14.SchemeColor schemeColor7 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            solidColorFillProperties6.Append(schemeColor7);
            W14.PresetLineDashProperties presetLineDashProperties4 = new W14.PresetLineDashProperties() { Val = W14.PresetLineDashValues.Solid };
            W14.RoundEmpty roundEmpty4 = new W14.RoundEmpty();

            textOutlineEffect4.Append(solidColorFillProperties6);
            textOutlineEffect4.Append(presetLineDashProperties4);
            textOutlineEffect4.Append(roundEmpty4);

            W14.FillTextEffect fillTextEffect3 = new W14.FillTextEffect();

            W14.SolidColorFillProperties solidColorFillProperties7 = new W14.SolidColorFillProperties();
            W14.RgbColorModelHex rgbColorModelHex4 = new W14.RgbColorModelHex() { Val = "FFFFFF" };

            solidColorFillProperties7.Append(rgbColorModelHex4);

            fillTextEffect3.Append(solidColorFillProperties7);

            paragraphMarkRunProperties2.Append(bold4);
            paragraphMarkRunProperties2.Append(outline3);
            paragraphMarkRunProperties2.Append(color4);
            paragraphMarkRunProperties2.Append(fontSize4);
            paragraphMarkRunProperties2.Append(fontSizeComplexScript4);
            paragraphMarkRunProperties2.Append(languages1);
            paragraphMarkRunProperties2.Append(shadow4);
            paragraphMarkRunProperties2.Append(reflection1);
            paragraphMarkRunProperties2.Append(textOutlineEffect4);
            paragraphMarkRunProperties2.Append(fillTextEffect3);

            paragraphProperties3.Append(paragraphMarkRunProperties2);

            Run run3 = new Run() { RsidRunProperties = "00827FBB" };

            RunProperties runProperties3 = new RunProperties();
            Bold bold5 = new Bold();
            Outline outline4 = new Outline();
            Color color5 = new Color() { Val = "ED7D31", ThemeColor = ThemeColorValues.Accent2 };
            FontSize fontSize5 = new FontSize() { Val = "144" };
            FontSizeComplexScript fontSizeComplexScript5 = new FontSizeComplexScript() { Val = "144" };
            Languages languages2 = new Languages() { Val = "en-US" };

            W14.Shadow shadow5 = new W14.Shadow() { BlurRadius = 63500L, DistanceFromText = 50800L, DirectionAngle = 0, HorizontalScalingFactor = 0, VerticalScalingFactor = 0, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.None };

            W14.RgbColorModelHex rgbColorModelHex5 = new W14.RgbColorModelHex() { Val = "000000" };
            W14.Alpha alpha2 = new W14.Alpha() { Val = 50000 };

            rgbColorModelHex5.Append(alpha2);

            shadow5.Append(rgbColorModelHex5);
            W14.Reflection reflection2 = new W14.Reflection() { BlurRadius = 6350L, StartingOpacity = 55000, StartPosition = 0, EndingOpacity = 300, EndPosition = 45500, DistanceFromText = 0L, DirectionAngle = 5400000, FadeDirection = 5400000, HorizontalScalingFactor = 100000, VerticalScalingFactor = -100000, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.BottomLeft };

            W14.TextOutlineEffect textOutlineEffect5 = new W14.TextOutlineEffect() { LineWidth = 6604, CapType = W14.LineCapValues.Flat, Compound = W14.CompoundLineValues.Simple, Alignment = W14.PenAlignmentValues.Center };

            W14.SolidColorFillProperties solidColorFillProperties8 = new W14.SolidColorFillProperties();
            W14.SchemeColor schemeColor8 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            solidColorFillProperties8.Append(schemeColor8);
            W14.PresetLineDashProperties presetLineDashProperties5 = new W14.PresetLineDashProperties() { Val = W14.PresetLineDashValues.Solid };
            W14.RoundEmpty roundEmpty5 = new W14.RoundEmpty();

            textOutlineEffect5.Append(solidColorFillProperties8);
            textOutlineEffect5.Append(presetLineDashProperties5);
            textOutlineEffect5.Append(roundEmpty5);

            W14.FillTextEffect fillTextEffect4 = new W14.FillTextEffect();

            W14.SolidColorFillProperties solidColorFillProperties9 = new W14.SolidColorFillProperties();
            W14.RgbColorModelHex rgbColorModelHex6 = new W14.RgbColorModelHex() { Val = "FFFFFF" };

            solidColorFillProperties9.Append(rgbColorModelHex6);

            fillTextEffect4.Append(solidColorFillProperties9);

            runProperties3.Append(bold5);
            runProperties3.Append(outline4);
            runProperties3.Append(color5);
            runProperties3.Append(fontSize5);
            runProperties3.Append(fontSizeComplexScript5);
            runProperties3.Append(languages2);
            runProperties3.Append(shadow5);
            runProperties3.Append(reflection2);
            runProperties3.Append(textOutlineEffect5);
            runProperties3.Append(fillTextEffect4);
            Text text3 = new Text();
            text3.Text = "V1";

            run3.Append(runProperties3);
            run3.Append(text3);

            paragraph3.Append(paragraphProperties3);
            paragraph3.Append(run3);

            tableCell1.Append(tableCellProperties1);
            tableCell1.Append(paragraph3);

            TableCell tableCell2 = new TableCell();

            TableCellProperties tableCellProperties2 = new TableCellProperties();
            TableCellWidth tableCellWidth2 = new TableCellWidth() { Width = "2336", Type = TableWidthUnitValues.Dxa };

            tableCellProperties2.Append(tableCellWidth2);

            Paragraph paragraph4 = new Paragraph() { RsidParagraphMarkRevision = "00827FBB", RsidParagraphAddition = "00827FBB", RsidRunAdditionDefault = "00827FBB", ParagraphId = "39ABD393", TextId = "74CA12E2" };

            ParagraphProperties paragraphProperties4 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties3 = new ParagraphMarkRunProperties();
            Bold bold6 = new Bold();
            Outline outline5 = new Outline();
            Color color6 = new Color() { Val = "ED7D31", ThemeColor = ThemeColorValues.Accent2 };
            FontSize fontSize6 = new FontSize() { Val = "144" };
            FontSizeComplexScript fontSizeComplexScript6 = new FontSizeComplexScript() { Val = "144" };
            Languages languages3 = new Languages() { Val = "en-US" };

            W14.Shadow shadow6 = new W14.Shadow() { BlurRadius = 63500L, DistanceFromText = 50800L, DirectionAngle = 0, HorizontalScalingFactor = 0, VerticalScalingFactor = 0, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.None };

            W14.RgbColorModelHex rgbColorModelHex7 = new W14.RgbColorModelHex() { Val = "000000" };
            W14.Alpha alpha3 = new W14.Alpha() { Val = 50000 };

            rgbColorModelHex7.Append(alpha3);

            shadow6.Append(rgbColorModelHex7);
            W14.Reflection reflection3 = new W14.Reflection() { BlurRadius = 6350L, StartingOpacity = 55000, StartPosition = 0, EndingOpacity = 300, EndPosition = 45500, DistanceFromText = 0L, DirectionAngle = 5400000, FadeDirection = 5400000, HorizontalScalingFactor = 100000, VerticalScalingFactor = -100000, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.BottomLeft };

            W14.TextOutlineEffect textOutlineEffect6 = new W14.TextOutlineEffect() { LineWidth = 6604, CapType = W14.LineCapValues.Flat, Compound = W14.CompoundLineValues.Simple, Alignment = W14.PenAlignmentValues.Center };

            W14.SolidColorFillProperties solidColorFillProperties10 = new W14.SolidColorFillProperties();
            W14.SchemeColor schemeColor9 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            solidColorFillProperties10.Append(schemeColor9);
            W14.PresetLineDashProperties presetLineDashProperties6 = new W14.PresetLineDashProperties() { Val = W14.PresetLineDashValues.Solid };
            W14.RoundEmpty roundEmpty6 = new W14.RoundEmpty();

            textOutlineEffect6.Append(solidColorFillProperties10);
            textOutlineEffect6.Append(presetLineDashProperties6);
            textOutlineEffect6.Append(roundEmpty6);

            W14.FillTextEffect fillTextEffect5 = new W14.FillTextEffect();

            W14.SolidColorFillProperties solidColorFillProperties11 = new W14.SolidColorFillProperties();
            W14.RgbColorModelHex rgbColorModelHex8 = new W14.RgbColorModelHex() { Val = "FFFFFF" };

            solidColorFillProperties11.Append(rgbColorModelHex8);

            fillTextEffect5.Append(solidColorFillProperties11);

            paragraphMarkRunProperties3.Append(bold6);
            paragraphMarkRunProperties3.Append(outline5);
            paragraphMarkRunProperties3.Append(color6);
            paragraphMarkRunProperties3.Append(fontSize6);
            paragraphMarkRunProperties3.Append(fontSizeComplexScript6);
            paragraphMarkRunProperties3.Append(languages3);
            paragraphMarkRunProperties3.Append(shadow6);
            paragraphMarkRunProperties3.Append(reflection3);
            paragraphMarkRunProperties3.Append(textOutlineEffect6);
            paragraphMarkRunProperties3.Append(fillTextEffect5);

            paragraphProperties4.Append(paragraphMarkRunProperties3);

            Run run4 = new Run() { RsidRunProperties = "00827FBB" };

            RunProperties runProperties4 = new RunProperties();
            Bold bold7 = new Bold();
            Outline outline6 = new Outline();
            Color color7 = new Color() { Val = "ED7D31", ThemeColor = ThemeColorValues.Accent2 };
            FontSize fontSize7 = new FontSize() { Val = "144" };
            FontSizeComplexScript fontSizeComplexScript7 = new FontSizeComplexScript() { Val = "144" };
            Languages languages4 = new Languages() { Val = "en-US" };

            W14.Shadow shadow7 = new W14.Shadow() { BlurRadius = 63500L, DistanceFromText = 50800L, DirectionAngle = 0, HorizontalScalingFactor = 0, VerticalScalingFactor = 0, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.None };

            W14.RgbColorModelHex rgbColorModelHex9 = new W14.RgbColorModelHex() { Val = "000000" };
            W14.Alpha alpha4 = new W14.Alpha() { Val = 50000 };

            rgbColorModelHex9.Append(alpha4);

            shadow7.Append(rgbColorModelHex9);
            W14.Reflection reflection4 = new W14.Reflection() { BlurRadius = 6350L, StartingOpacity = 55000, StartPosition = 0, EndingOpacity = 300, EndPosition = 45500, DistanceFromText = 0L, DirectionAngle = 5400000, FadeDirection = 5400000, HorizontalScalingFactor = 100000, VerticalScalingFactor = -100000, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.BottomLeft };

            W14.TextOutlineEffect textOutlineEffect7 = new W14.TextOutlineEffect() { LineWidth = 6604, CapType = W14.LineCapValues.Flat, Compound = W14.CompoundLineValues.Simple, Alignment = W14.PenAlignmentValues.Center };

            W14.SolidColorFillProperties solidColorFillProperties12 = new W14.SolidColorFillProperties();
            W14.SchemeColor schemeColor10 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            solidColorFillProperties12.Append(schemeColor10);
            W14.PresetLineDashProperties presetLineDashProperties7 = new W14.PresetLineDashProperties() { Val = W14.PresetLineDashValues.Solid };
            W14.RoundEmpty roundEmpty7 = new W14.RoundEmpty();

            textOutlineEffect7.Append(solidColorFillProperties12);
            textOutlineEffect7.Append(presetLineDashProperties7);
            textOutlineEffect7.Append(roundEmpty7);

            W14.FillTextEffect fillTextEffect6 = new W14.FillTextEffect();

            W14.SolidColorFillProperties solidColorFillProperties13 = new W14.SolidColorFillProperties();
            W14.RgbColorModelHex rgbColorModelHex10 = new W14.RgbColorModelHex() { Val = "FFFFFF" };

            solidColorFillProperties13.Append(rgbColorModelHex10);

            fillTextEffect6.Append(solidColorFillProperties13);

            runProperties4.Append(bold7);
            runProperties4.Append(outline6);
            runProperties4.Append(color7);
            runProperties4.Append(fontSize7);
            runProperties4.Append(fontSizeComplexScript7);
            runProperties4.Append(languages4);
            runProperties4.Append(shadow7);
            runProperties4.Append(reflection4);
            runProperties4.Append(textOutlineEffect7);
            runProperties4.Append(fillTextEffect6);
            Text text4 = new Text();
            text4.Text = "V2";

            run4.Append(runProperties4);
            run4.Append(text4);

            paragraph4.Append(paragraphProperties4);
            paragraph4.Append(run4);

            tableCell2.Append(tableCellProperties2);
            tableCell2.Append(paragraph4);

            TableCell tableCell3 = new TableCell();

            TableCellProperties tableCellProperties3 = new TableCellProperties();
            TableCellWidth tableCellWidth3 = new TableCellWidth() { Width = "2336", Type = TableWidthUnitValues.Dxa };

            tableCellProperties3.Append(tableCellWidth3);

            Paragraph paragraph5 = new Paragraph() { RsidParagraphMarkRevision = "00827FBB", RsidParagraphAddition = "00827FBB", RsidRunAdditionDefault = "00827FBB", ParagraphId = "0FE08579", TextId = "77777777" };

            ParagraphProperties paragraphProperties5 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties4 = new ParagraphMarkRunProperties();
            Bold bold8 = new Bold();
            Outline outline7 = new Outline();
            Color color8 = new Color() { Val = "ED7D31", ThemeColor = ThemeColorValues.Accent2 };
            FontSize fontSize8 = new FontSize() { Val = "144" };
            FontSizeComplexScript fontSizeComplexScript8 = new FontSizeComplexScript() { Val = "144" };

            W14.Shadow shadow8 = new W14.Shadow() { BlurRadius = 63500L, DistanceFromText = 50800L, DirectionAngle = 0, HorizontalScalingFactor = 0, VerticalScalingFactor = 0, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.None };

            W14.RgbColorModelHex rgbColorModelHex11 = new W14.RgbColorModelHex() { Val = "000000" };
            W14.Alpha alpha5 = new W14.Alpha() { Val = 50000 };

            rgbColorModelHex11.Append(alpha5);

            shadow8.Append(rgbColorModelHex11);
            W14.Reflection reflection5 = new W14.Reflection() { BlurRadius = 6350L, StartingOpacity = 55000, StartPosition = 0, EndingOpacity = 300, EndPosition = 45500, DistanceFromText = 0L, DirectionAngle = 5400000, FadeDirection = 5400000, HorizontalScalingFactor = 100000, VerticalScalingFactor = -100000, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.BottomLeft };

            W14.TextOutlineEffect textOutlineEffect8 = new W14.TextOutlineEffect() { LineWidth = 6604, CapType = W14.LineCapValues.Flat, Compound = W14.CompoundLineValues.Simple, Alignment = W14.PenAlignmentValues.Center };

            W14.SolidColorFillProperties solidColorFillProperties14 = new W14.SolidColorFillProperties();
            W14.SchemeColor schemeColor11 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            solidColorFillProperties14.Append(schemeColor11);
            W14.PresetLineDashProperties presetLineDashProperties8 = new W14.PresetLineDashProperties() { Val = W14.PresetLineDashValues.Solid };
            W14.RoundEmpty roundEmpty8 = new W14.RoundEmpty();

            textOutlineEffect8.Append(solidColorFillProperties14);
            textOutlineEffect8.Append(presetLineDashProperties8);
            textOutlineEffect8.Append(roundEmpty8);

            W14.FillTextEffect fillTextEffect7 = new W14.FillTextEffect();

            W14.SolidColorFillProperties solidColorFillProperties15 = new W14.SolidColorFillProperties();
            W14.RgbColorModelHex rgbColorModelHex12 = new W14.RgbColorModelHex() { Val = "FFFFFF" };

            solidColorFillProperties15.Append(rgbColorModelHex12);

            fillTextEffect7.Append(solidColorFillProperties15);

            paragraphMarkRunProperties4.Append(bold8);
            paragraphMarkRunProperties4.Append(outline7);
            paragraphMarkRunProperties4.Append(color8);
            paragraphMarkRunProperties4.Append(fontSize8);
            paragraphMarkRunProperties4.Append(fontSizeComplexScript8);
            paragraphMarkRunProperties4.Append(shadow8);
            paragraphMarkRunProperties4.Append(reflection5);
            paragraphMarkRunProperties4.Append(textOutlineEffect8);
            paragraphMarkRunProperties4.Append(fillTextEffect7);

            paragraphProperties5.Append(paragraphMarkRunProperties4);

            paragraph5.Append(paragraphProperties5);

            tableCell3.Append(tableCellProperties3);
            tableCell3.Append(paragraph5);

            TableCell tableCell4 = new TableCell();

            TableCellProperties tableCellProperties4 = new TableCellProperties();
            TableCellWidth tableCellWidth4 = new TableCellWidth() { Width = "2337", Type = TableWidthUnitValues.Dxa };

            tableCellProperties4.Append(tableCellWidth4);

            Paragraph paragraph6 = new Paragraph() { RsidParagraphMarkRevision = "00827FBB", RsidParagraphAddition = "00827FBB", RsidRunAdditionDefault = "00827FBB", ParagraphId = "336D28FB", TextId = "77777777" };

            ParagraphProperties paragraphProperties6 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties5 = new ParagraphMarkRunProperties();
            Bold bold9 = new Bold();
            Outline outline8 = new Outline();
            Color color9 = new Color() { Val = "ED7D31", ThemeColor = ThemeColorValues.Accent2 };
            FontSize fontSize9 = new FontSize() { Val = "144" };
            FontSizeComplexScript fontSizeComplexScript9 = new FontSizeComplexScript() { Val = "144" };

            W14.Shadow shadow9 = new W14.Shadow() { BlurRadius = 63500L, DistanceFromText = 50800L, DirectionAngle = 0, HorizontalScalingFactor = 0, VerticalScalingFactor = 0, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.None };

            W14.RgbColorModelHex rgbColorModelHex13 = new W14.RgbColorModelHex() { Val = "000000" };
            W14.Alpha alpha6 = new W14.Alpha() { Val = 50000 };

            rgbColorModelHex13.Append(alpha6);

            shadow9.Append(rgbColorModelHex13);
            W14.Reflection reflection6 = new W14.Reflection() { BlurRadius = 6350L, StartingOpacity = 55000, StartPosition = 0, EndingOpacity = 300, EndPosition = 45500, DistanceFromText = 0L, DirectionAngle = 5400000, FadeDirection = 5400000, HorizontalScalingFactor = 100000, VerticalScalingFactor = -100000, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.BottomLeft };

            W14.TextOutlineEffect textOutlineEffect9 = new W14.TextOutlineEffect() { LineWidth = 6604, CapType = W14.LineCapValues.Flat, Compound = W14.CompoundLineValues.Simple, Alignment = W14.PenAlignmentValues.Center };

            W14.SolidColorFillProperties solidColorFillProperties16 = new W14.SolidColorFillProperties();
            W14.SchemeColor schemeColor12 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            solidColorFillProperties16.Append(schemeColor12);
            W14.PresetLineDashProperties presetLineDashProperties9 = new W14.PresetLineDashProperties() { Val = W14.PresetLineDashValues.Solid };
            W14.RoundEmpty roundEmpty9 = new W14.RoundEmpty();

            textOutlineEffect9.Append(solidColorFillProperties16);
            textOutlineEffect9.Append(presetLineDashProperties9);
            textOutlineEffect9.Append(roundEmpty9);

            W14.FillTextEffect fillTextEffect8 = new W14.FillTextEffect();

            W14.SolidColorFillProperties solidColorFillProperties17 = new W14.SolidColorFillProperties();
            W14.RgbColorModelHex rgbColorModelHex14 = new W14.RgbColorModelHex() { Val = "FFFFFF" };

            solidColorFillProperties17.Append(rgbColorModelHex14);

            fillTextEffect8.Append(solidColorFillProperties17);

            paragraphMarkRunProperties5.Append(bold9);
            paragraphMarkRunProperties5.Append(outline8);
            paragraphMarkRunProperties5.Append(color9);
            paragraphMarkRunProperties5.Append(fontSize9);
            paragraphMarkRunProperties5.Append(fontSizeComplexScript9);
            paragraphMarkRunProperties5.Append(shadow9);
            paragraphMarkRunProperties5.Append(reflection6);
            paragraphMarkRunProperties5.Append(textOutlineEffect9);
            paragraphMarkRunProperties5.Append(fillTextEffect8);

            paragraphProperties6.Append(paragraphMarkRunProperties5);

            paragraph6.Append(paragraphProperties6);

            tableCell4.Append(tableCellProperties4);
            tableCell4.Append(paragraph6);

            tableRow1.Append(tableCell1);
            tableRow1.Append(tableCell2);
            tableRow1.Append(tableCell3);
            tableRow1.Append(tableCell4);

            TableRow tableRow2 = new TableRow() { RsidTableRowAddition = "00827FBB", RsidTableRowProperties = "00827FBB", ParagraphId = "28748E48", TextId = "77777777" };

            TableCell tableCell5 = new TableCell();

            TableCellProperties tableCellProperties5 = new TableCellProperties();
            TableCellWidth tableCellWidth5 = new TableCellWidth() { Width = "2336", Type = TableWidthUnitValues.Dxa };

            tableCellProperties5.Append(tableCellWidth5);

            Paragraph paragraph7 = new Paragraph() { RsidParagraphMarkRevision = "00827FBB", RsidParagraphAddition = "00827FBB", RsidRunAdditionDefault = "00827FBB", ParagraphId = "4912BD4F", TextId = "77777777" };

            ParagraphProperties paragraphProperties7 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties6 = new ParagraphMarkRunProperties();
            Bold bold10 = new Bold();
            Outline outline9 = new Outline();
            Color color10 = new Color() { Val = "ED7D31", ThemeColor = ThemeColorValues.Accent2 };
            FontSize fontSize10 = new FontSize() { Val = "144" };
            FontSizeComplexScript fontSizeComplexScript10 = new FontSizeComplexScript() { Val = "144" };

            W14.Shadow shadow10 = new W14.Shadow() { BlurRadius = 63500L, DistanceFromText = 50800L, DirectionAngle = 0, HorizontalScalingFactor = 0, VerticalScalingFactor = 0, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.None };

            W14.RgbColorModelHex rgbColorModelHex15 = new W14.RgbColorModelHex() { Val = "000000" };
            W14.Alpha alpha7 = new W14.Alpha() { Val = 50000 };

            rgbColorModelHex15.Append(alpha7);

            shadow10.Append(rgbColorModelHex15);
            W14.Reflection reflection7 = new W14.Reflection() { BlurRadius = 6350L, StartingOpacity = 55000, StartPosition = 0, EndingOpacity = 300, EndPosition = 45500, DistanceFromText = 0L, DirectionAngle = 5400000, FadeDirection = 5400000, HorizontalScalingFactor = 100000, VerticalScalingFactor = -100000, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.BottomLeft };

            W14.TextOutlineEffect textOutlineEffect10 = new W14.TextOutlineEffect() { LineWidth = 6604, CapType = W14.LineCapValues.Flat, Compound = W14.CompoundLineValues.Simple, Alignment = W14.PenAlignmentValues.Center };

            W14.SolidColorFillProperties solidColorFillProperties18 = new W14.SolidColorFillProperties();
            W14.SchemeColor schemeColor13 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            solidColorFillProperties18.Append(schemeColor13);
            W14.PresetLineDashProperties presetLineDashProperties10 = new W14.PresetLineDashProperties() { Val = W14.PresetLineDashValues.Solid };
            W14.RoundEmpty roundEmpty10 = new W14.RoundEmpty();

            textOutlineEffect10.Append(solidColorFillProperties18);
            textOutlineEffect10.Append(presetLineDashProperties10);
            textOutlineEffect10.Append(roundEmpty10);

            W14.FillTextEffect fillTextEffect9 = new W14.FillTextEffect();

            W14.SolidColorFillProperties solidColorFillProperties19 = new W14.SolidColorFillProperties();
            W14.RgbColorModelHex rgbColorModelHex16 = new W14.RgbColorModelHex() { Val = "FFFFFF" };

            solidColorFillProperties19.Append(rgbColorModelHex16);

            fillTextEffect9.Append(solidColorFillProperties19);

            paragraphMarkRunProperties6.Append(bold10);
            paragraphMarkRunProperties6.Append(outline9);
            paragraphMarkRunProperties6.Append(color10);
            paragraphMarkRunProperties6.Append(fontSize10);
            paragraphMarkRunProperties6.Append(fontSizeComplexScript10);
            paragraphMarkRunProperties6.Append(shadow10);
            paragraphMarkRunProperties6.Append(reflection7);
            paragraphMarkRunProperties6.Append(textOutlineEffect10);
            paragraphMarkRunProperties6.Append(fillTextEffect9);

            paragraphProperties7.Append(paragraphMarkRunProperties6);

            paragraph7.Append(paragraphProperties7);

            tableCell5.Append(tableCellProperties5);
            tableCell5.Append(paragraph7);

            TableCell tableCell6 = new TableCell();

            TableCellProperties tableCellProperties6 = new TableCellProperties();
            TableCellWidth tableCellWidth6 = new TableCellWidth() { Width = "2336", Type = TableWidthUnitValues.Dxa };

            tableCellProperties6.Append(tableCellWidth6);

            Paragraph paragraph8 = new Paragraph() { RsidParagraphMarkRevision = "00827FBB", RsidParagraphAddition = "00827FBB", RsidRunAdditionDefault = "00827FBB", ParagraphId = "6EF55ABC", TextId = "3C4DD4D1" };

            ParagraphProperties paragraphProperties8 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties7 = new ParagraphMarkRunProperties();
            Bold bold11 = new Bold();
            Outline outline10 = new Outline();
            Color color11 = new Color() { Val = "ED7D31", ThemeColor = ThemeColorValues.Accent2 };
            FontSize fontSize11 = new FontSize() { Val = "144" };
            FontSizeComplexScript fontSizeComplexScript11 = new FontSizeComplexScript() { Val = "144" };
            Languages languages5 = new Languages() { Val = "en-US" };

            W14.Shadow shadow11 = new W14.Shadow() { BlurRadius = 63500L, DistanceFromText = 50800L, DirectionAngle = 0, HorizontalScalingFactor = 0, VerticalScalingFactor = 0, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.None };

            W14.RgbColorModelHex rgbColorModelHex17 = new W14.RgbColorModelHex() { Val = "000000" };
            W14.Alpha alpha8 = new W14.Alpha() { Val = 50000 };

            rgbColorModelHex17.Append(alpha8);

            shadow11.Append(rgbColorModelHex17);
            W14.Reflection reflection8 = new W14.Reflection() { BlurRadius = 6350L, StartingOpacity = 55000, StartPosition = 0, EndingOpacity = 300, EndPosition = 45500, DistanceFromText = 0L, DirectionAngle = 5400000, FadeDirection = 5400000, HorizontalScalingFactor = 100000, VerticalScalingFactor = -100000, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.BottomLeft };

            W14.TextOutlineEffect textOutlineEffect11 = new W14.TextOutlineEffect() { LineWidth = 6604, CapType = W14.LineCapValues.Flat, Compound = W14.CompoundLineValues.Simple, Alignment = W14.PenAlignmentValues.Center };

            W14.SolidColorFillProperties solidColorFillProperties20 = new W14.SolidColorFillProperties();
            W14.SchemeColor schemeColor14 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            solidColorFillProperties20.Append(schemeColor14);
            W14.PresetLineDashProperties presetLineDashProperties11 = new W14.PresetLineDashProperties() { Val = W14.PresetLineDashValues.Solid };
            W14.RoundEmpty roundEmpty11 = new W14.RoundEmpty();

            textOutlineEffect11.Append(solidColorFillProperties20);
            textOutlineEffect11.Append(presetLineDashProperties11);
            textOutlineEffect11.Append(roundEmpty11);

            W14.FillTextEffect fillTextEffect10 = new W14.FillTextEffect();

            W14.SolidColorFillProperties solidColorFillProperties21 = new W14.SolidColorFillProperties();
            W14.RgbColorModelHex rgbColorModelHex18 = new W14.RgbColorModelHex() { Val = "FFFFFF" };

            solidColorFillProperties21.Append(rgbColorModelHex18);

            fillTextEffect10.Append(solidColorFillProperties21);

            paragraphMarkRunProperties7.Append(bold11);
            paragraphMarkRunProperties7.Append(outline10);
            paragraphMarkRunProperties7.Append(color11);
            paragraphMarkRunProperties7.Append(fontSize11);
            paragraphMarkRunProperties7.Append(fontSizeComplexScript11);
            paragraphMarkRunProperties7.Append(languages5);
            paragraphMarkRunProperties7.Append(shadow11);
            paragraphMarkRunProperties7.Append(reflection8);
            paragraphMarkRunProperties7.Append(textOutlineEffect11);
            paragraphMarkRunProperties7.Append(fillTextEffect10);

            paragraphProperties8.Append(paragraphMarkRunProperties7);

            Run run5 = new Run() { RsidRunProperties = "00827FBB" };

            RunProperties runProperties5 = new RunProperties();
            Bold bold12 = new Bold();
            Outline outline11 = new Outline();
            Color color12 = new Color() { Val = "ED7D31", ThemeColor = ThemeColorValues.Accent2 };
            FontSize fontSize12 = new FontSize() { Val = "144" };
            FontSizeComplexScript fontSizeComplexScript12 = new FontSizeComplexScript() { Val = "144" };
            Languages languages6 = new Languages() { Val = "en-US" };

            W14.Shadow shadow12 = new W14.Shadow() { BlurRadius = 63500L, DistanceFromText = 50800L, DirectionAngle = 0, HorizontalScalingFactor = 0, VerticalScalingFactor = 0, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.None };

            W14.RgbColorModelHex rgbColorModelHex19 = new W14.RgbColorModelHex() { Val = "000000" };
            W14.Alpha alpha9 = new W14.Alpha() { Val = 50000 };

            rgbColorModelHex19.Append(alpha9);

            shadow12.Append(rgbColorModelHex19);
            W14.Reflection reflection9 = new W14.Reflection() { BlurRadius = 6350L, StartingOpacity = 55000, StartPosition = 0, EndingOpacity = 300, EndPosition = 45500, DistanceFromText = 0L, DirectionAngle = 5400000, FadeDirection = 5400000, HorizontalScalingFactor = 100000, VerticalScalingFactor = -100000, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.BottomLeft };

            W14.TextOutlineEffect textOutlineEffect12 = new W14.TextOutlineEffect() { LineWidth = 6604, CapType = W14.LineCapValues.Flat, Compound = W14.CompoundLineValues.Simple, Alignment = W14.PenAlignmentValues.Center };

            W14.SolidColorFillProperties solidColorFillProperties22 = new W14.SolidColorFillProperties();
            W14.SchemeColor schemeColor15 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            solidColorFillProperties22.Append(schemeColor15);
            W14.PresetLineDashProperties presetLineDashProperties12 = new W14.PresetLineDashProperties() { Val = W14.PresetLineDashValues.Solid };
            W14.RoundEmpty roundEmpty12 = new W14.RoundEmpty();

            textOutlineEffect12.Append(solidColorFillProperties22);
            textOutlineEffect12.Append(presetLineDashProperties12);
            textOutlineEffect12.Append(roundEmpty12);

            W14.FillTextEffect fillTextEffect11 = new W14.FillTextEffect();

            W14.SolidColorFillProperties solidColorFillProperties23 = new W14.SolidColorFillProperties();
            W14.RgbColorModelHex rgbColorModelHex20 = new W14.RgbColorModelHex() { Val = "FFFFFF" };

            solidColorFillProperties23.Append(rgbColorModelHex20);

            fillTextEffect11.Append(solidColorFillProperties23);

            runProperties5.Append(bold12);
            runProperties5.Append(outline11);
            runProperties5.Append(color12);
            runProperties5.Append(fontSize12);
            runProperties5.Append(fontSizeComplexScript12);
            runProperties5.Append(languages6);
            runProperties5.Append(shadow12);
            runProperties5.Append(reflection9);
            runProperties5.Append(textOutlineEffect12);
            runProperties5.Append(fillTextEffect11);
            Text text5 = new Text();
            text5.Text = DataV3;

            run5.Append(runProperties5);
            run5.Append(text5);

            paragraph8.Append(paragraphProperties8);
            paragraph8.Append(run5);

            tableCell6.Append(tableCellProperties6);
            tableCell6.Append(paragraph8);

            TableCell tableCell7 = new TableCell();

            TableCellProperties tableCellProperties7 = new TableCellProperties();
            TableCellWidth tableCellWidth7 = new TableCellWidth() { Width = "2336", Type = TableWidthUnitValues.Dxa };

            tableCellProperties7.Append(tableCellWidth7);

            Paragraph paragraph9 = new Paragraph() { RsidParagraphMarkRevision = "00827FBB", RsidParagraphAddition = "00827FBB", RsidRunAdditionDefault = "00827FBB", ParagraphId = "55A6D2BC", TextId = "77777777" };

            ParagraphProperties paragraphProperties9 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties8 = new ParagraphMarkRunProperties();
            Bold bold13 = new Bold();
            Outline outline12 = new Outline();
            Color color13 = new Color() { Val = "ED7D31", ThemeColor = ThemeColorValues.Accent2 };
            FontSize fontSize13 = new FontSize() { Val = "144" };
            FontSizeComplexScript fontSizeComplexScript13 = new FontSizeComplexScript() { Val = "144" };

            W14.Shadow shadow13 = new W14.Shadow() { BlurRadius = 63500L, DistanceFromText = 50800L, DirectionAngle = 0, HorizontalScalingFactor = 0, VerticalScalingFactor = 0, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.None };

            W14.RgbColorModelHex rgbColorModelHex21 = new W14.RgbColorModelHex() { Val = "000000" };
            W14.Alpha alpha10 = new W14.Alpha() { Val = 50000 };

            rgbColorModelHex21.Append(alpha10);

            shadow13.Append(rgbColorModelHex21);
            W14.Reflection reflection10 = new W14.Reflection() { BlurRadius = 6350L, StartingOpacity = 55000, StartPosition = 0, EndingOpacity = 300, EndPosition = 45500, DistanceFromText = 0L, DirectionAngle = 5400000, FadeDirection = 5400000, HorizontalScalingFactor = 100000, VerticalScalingFactor = -100000, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.BottomLeft };

            W14.TextOutlineEffect textOutlineEffect13 = new W14.TextOutlineEffect() { LineWidth = 6604, CapType = W14.LineCapValues.Flat, Compound = W14.CompoundLineValues.Simple, Alignment = W14.PenAlignmentValues.Center };

            W14.SolidColorFillProperties solidColorFillProperties24 = new W14.SolidColorFillProperties();
            W14.SchemeColor schemeColor16 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            solidColorFillProperties24.Append(schemeColor16);
            W14.PresetLineDashProperties presetLineDashProperties13 = new W14.PresetLineDashProperties() { Val = W14.PresetLineDashValues.Solid };
            W14.RoundEmpty roundEmpty13 = new W14.RoundEmpty();

            textOutlineEffect13.Append(solidColorFillProperties24);
            textOutlineEffect13.Append(presetLineDashProperties13);
            textOutlineEffect13.Append(roundEmpty13);

            W14.FillTextEffect fillTextEffect12 = new W14.FillTextEffect();

            W14.SolidColorFillProperties solidColorFillProperties25 = new W14.SolidColorFillProperties();
            W14.RgbColorModelHex rgbColorModelHex22 = new W14.RgbColorModelHex() { Val = "FFFFFF" };

            solidColorFillProperties25.Append(rgbColorModelHex22);

            fillTextEffect12.Append(solidColorFillProperties25);

            paragraphMarkRunProperties8.Append(bold13);
            paragraphMarkRunProperties8.Append(outline12);
            paragraphMarkRunProperties8.Append(color13);
            paragraphMarkRunProperties8.Append(fontSize13);
            paragraphMarkRunProperties8.Append(fontSizeComplexScript13);
            paragraphMarkRunProperties8.Append(shadow13);
            paragraphMarkRunProperties8.Append(reflection10);
            paragraphMarkRunProperties8.Append(textOutlineEffect13);
            paragraphMarkRunProperties8.Append(fillTextEffect12);

            paragraphProperties9.Append(paragraphMarkRunProperties8);

            paragraph9.Append(paragraphProperties9);

            tableCell7.Append(tableCellProperties7);
            tableCell7.Append(paragraph9);

            TableCell tableCell8 = new TableCell();

            TableCellProperties tableCellProperties8 = new TableCellProperties();
            TableCellWidth tableCellWidth8 = new TableCellWidth() { Width = "2337", Type = TableWidthUnitValues.Dxa };

            tableCellProperties8.Append(tableCellWidth8);

            Paragraph paragraph10 = new Paragraph() { RsidParagraphMarkRevision = "00827FBB", RsidParagraphAddition = "00827FBB", RsidRunAdditionDefault = "00827FBB", ParagraphId = "7BEF5A9F", TextId = "77777777" };

            ParagraphProperties paragraphProperties10 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties9 = new ParagraphMarkRunProperties();
            Bold bold14 = new Bold();
            Outline outline13 = new Outline();
            Color color14 = new Color() { Val = "ED7D31", ThemeColor = ThemeColorValues.Accent2 };
            FontSize fontSize14 = new FontSize() { Val = "144" };
            FontSizeComplexScript fontSizeComplexScript14 = new FontSizeComplexScript() { Val = "144" };

            W14.Shadow shadow14 = new W14.Shadow() { BlurRadius = 63500L, DistanceFromText = 50800L, DirectionAngle = 0, HorizontalScalingFactor = 0, VerticalScalingFactor = 0, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.None };

            W14.RgbColorModelHex rgbColorModelHex23 = new W14.RgbColorModelHex() { Val = "000000" };
            W14.Alpha alpha11 = new W14.Alpha() { Val = 50000 };

            rgbColorModelHex23.Append(alpha11);

            shadow14.Append(rgbColorModelHex23);
            W14.Reflection reflection11 = new W14.Reflection() { BlurRadius = 6350L, StartingOpacity = 55000, StartPosition = 0, EndingOpacity = 300, EndPosition = 45500, DistanceFromText = 0L, DirectionAngle = 5400000, FadeDirection = 5400000, HorizontalScalingFactor = 100000, VerticalScalingFactor = -100000, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.BottomLeft };

            W14.TextOutlineEffect textOutlineEffect14 = new W14.TextOutlineEffect() { LineWidth = 6604, CapType = W14.LineCapValues.Flat, Compound = W14.CompoundLineValues.Simple, Alignment = W14.PenAlignmentValues.Center };

            W14.SolidColorFillProperties solidColorFillProperties26 = new W14.SolidColorFillProperties();
            W14.SchemeColor schemeColor17 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            solidColorFillProperties26.Append(schemeColor17);
            W14.PresetLineDashProperties presetLineDashProperties14 = new W14.PresetLineDashProperties() { Val = W14.PresetLineDashValues.Solid };
            W14.RoundEmpty roundEmpty14 = new W14.RoundEmpty();

            textOutlineEffect14.Append(solidColorFillProperties26);
            textOutlineEffect14.Append(presetLineDashProperties14);
            textOutlineEffect14.Append(roundEmpty14);

            W14.FillTextEffect fillTextEffect13 = new W14.FillTextEffect();

            W14.SolidColorFillProperties solidColorFillProperties27 = new W14.SolidColorFillProperties();
            W14.RgbColorModelHex rgbColorModelHex24 = new W14.RgbColorModelHex() { Val = "FFFFFF" };

            solidColorFillProperties27.Append(rgbColorModelHex24);

            fillTextEffect13.Append(solidColorFillProperties27);

            paragraphMarkRunProperties9.Append(bold14);
            paragraphMarkRunProperties9.Append(outline13);
            paragraphMarkRunProperties9.Append(color14);
            paragraphMarkRunProperties9.Append(fontSize14);
            paragraphMarkRunProperties9.Append(fontSizeComplexScript14);
            paragraphMarkRunProperties9.Append(shadow14);
            paragraphMarkRunProperties9.Append(reflection11);
            paragraphMarkRunProperties9.Append(textOutlineEffect14);
            paragraphMarkRunProperties9.Append(fillTextEffect13);

            paragraphProperties10.Append(paragraphMarkRunProperties9);

            paragraph10.Append(paragraphProperties10);

            tableCell8.Append(tableCellProperties8);
            tableCell8.Append(paragraph10);

            tableRow2.Append(tableCell5);
            tableRow2.Append(tableCell6);
            tableRow2.Append(tableCell7);
            tableRow2.Append(tableCell8);

            TableRow tableRow3 = new TableRow() { RsidTableRowAddition = "00827FBB", RsidTableRowProperties = "00827FBB", ParagraphId = "1A181007", TextId = "77777777" };

            TableCell tableCell9 = new TableCell();

            TableCellProperties tableCellProperties9 = new TableCellProperties();
            TableCellWidth tableCellWidth9 = new TableCellWidth() { Width = "2336", Type = TableWidthUnitValues.Dxa };

            tableCellProperties9.Append(tableCellWidth9);

            Paragraph paragraph11 = new Paragraph() { RsidParagraphMarkRevision = "00827FBB", RsidParagraphAddition = "00827FBB", RsidRunAdditionDefault = "00827FBB", ParagraphId = "1A833833", TextId = "77777777" };

            ParagraphProperties paragraphProperties11 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties10 = new ParagraphMarkRunProperties();
            Bold bold15 = new Bold();
            Outline outline14 = new Outline();
            Color color15 = new Color() { Val = "ED7D31", ThemeColor = ThemeColorValues.Accent2 };
            FontSize fontSize15 = new FontSize() { Val = "144" };
            FontSizeComplexScript fontSizeComplexScript15 = new FontSizeComplexScript() { Val = "144" };

            W14.Shadow shadow15 = new W14.Shadow() { BlurRadius = 63500L, DistanceFromText = 50800L, DirectionAngle = 0, HorizontalScalingFactor = 0, VerticalScalingFactor = 0, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.None };

            W14.RgbColorModelHex rgbColorModelHex25 = new W14.RgbColorModelHex() { Val = "000000" };
            W14.Alpha alpha12 = new W14.Alpha() { Val = 50000 };

            rgbColorModelHex25.Append(alpha12);

            shadow15.Append(rgbColorModelHex25);
            W14.Reflection reflection12 = new W14.Reflection() { BlurRadius = 6350L, StartingOpacity = 55000, StartPosition = 0, EndingOpacity = 300, EndPosition = 45500, DistanceFromText = 0L, DirectionAngle = 5400000, FadeDirection = 5400000, HorizontalScalingFactor = 100000, VerticalScalingFactor = -100000, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.BottomLeft };

            W14.TextOutlineEffect textOutlineEffect15 = new W14.TextOutlineEffect() { LineWidth = 6604, CapType = W14.LineCapValues.Flat, Compound = W14.CompoundLineValues.Simple, Alignment = W14.PenAlignmentValues.Center };

            W14.SolidColorFillProperties solidColorFillProperties28 = new W14.SolidColorFillProperties();
            W14.SchemeColor schemeColor18 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            solidColorFillProperties28.Append(schemeColor18);
            W14.PresetLineDashProperties presetLineDashProperties15 = new W14.PresetLineDashProperties() { Val = W14.PresetLineDashValues.Solid };
            W14.RoundEmpty roundEmpty15 = new W14.RoundEmpty();

            textOutlineEffect15.Append(solidColorFillProperties28);
            textOutlineEffect15.Append(presetLineDashProperties15);
            textOutlineEffect15.Append(roundEmpty15);

            W14.FillTextEffect fillTextEffect14 = new W14.FillTextEffect();

            W14.SolidColorFillProperties solidColorFillProperties29 = new W14.SolidColorFillProperties();
            W14.RgbColorModelHex rgbColorModelHex26 = new W14.RgbColorModelHex() { Val = "FFFFFF" };

            solidColorFillProperties29.Append(rgbColorModelHex26);

            fillTextEffect14.Append(solidColorFillProperties29);

            paragraphMarkRunProperties10.Append(bold15);
            paragraphMarkRunProperties10.Append(outline14);
            paragraphMarkRunProperties10.Append(color15);
            paragraphMarkRunProperties10.Append(fontSize15);
            paragraphMarkRunProperties10.Append(fontSizeComplexScript15);
            paragraphMarkRunProperties10.Append(shadow15);
            paragraphMarkRunProperties10.Append(reflection12);
            paragraphMarkRunProperties10.Append(textOutlineEffect15);
            paragraphMarkRunProperties10.Append(fillTextEffect14);

            paragraphProperties11.Append(paragraphMarkRunProperties10);

            paragraph11.Append(paragraphProperties11);

            tableCell9.Append(tableCellProperties9);
            tableCell9.Append(paragraph11);

            TableCell tableCell10 = new TableCell();

            TableCellProperties tableCellProperties10 = new TableCellProperties();
            TableCellWidth tableCellWidth10 = new TableCellWidth() { Width = "2336", Type = TableWidthUnitValues.Dxa };

            tableCellProperties10.Append(tableCellWidth10);

            Paragraph paragraph12 = new Paragraph() { RsidParagraphMarkRevision = "00827FBB", RsidParagraphAddition = "00827FBB", RsidRunAdditionDefault = "00827FBB", ParagraphId = "370FC06A", TextId = "77777777" };

            ParagraphProperties paragraphProperties12 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties11 = new ParagraphMarkRunProperties();
            Bold bold16 = new Bold();
            Outline outline15 = new Outline();
            Color color16 = new Color() { Val = "ED7D31", ThemeColor = ThemeColorValues.Accent2 };
            FontSize fontSize16 = new FontSize() { Val = "144" };
            FontSizeComplexScript fontSizeComplexScript16 = new FontSizeComplexScript() { Val = "144" };

            W14.Shadow shadow16 = new W14.Shadow() { BlurRadius = 63500L, DistanceFromText = 50800L, DirectionAngle = 0, HorizontalScalingFactor = 0, VerticalScalingFactor = 0, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.None };

            W14.RgbColorModelHex rgbColorModelHex27 = new W14.RgbColorModelHex() { Val = "000000" };
            W14.Alpha alpha13 = new W14.Alpha() { Val = 50000 };

            rgbColorModelHex27.Append(alpha13);

            shadow16.Append(rgbColorModelHex27);
            W14.Reflection reflection13 = new W14.Reflection() { BlurRadius = 6350L, StartingOpacity = 55000, StartPosition = 0, EndingOpacity = 300, EndPosition = 45500, DistanceFromText = 0L, DirectionAngle = 5400000, FadeDirection = 5400000, HorizontalScalingFactor = 100000, VerticalScalingFactor = -100000, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.BottomLeft };

            W14.TextOutlineEffect textOutlineEffect16 = new W14.TextOutlineEffect() { LineWidth = 6604, CapType = W14.LineCapValues.Flat, Compound = W14.CompoundLineValues.Simple, Alignment = W14.PenAlignmentValues.Center };

            W14.SolidColorFillProperties solidColorFillProperties30 = new W14.SolidColorFillProperties();
            W14.SchemeColor schemeColor19 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            solidColorFillProperties30.Append(schemeColor19);
            W14.PresetLineDashProperties presetLineDashProperties16 = new W14.PresetLineDashProperties() { Val = W14.PresetLineDashValues.Solid };
            W14.RoundEmpty roundEmpty16 = new W14.RoundEmpty();

            textOutlineEffect16.Append(solidColorFillProperties30);
            textOutlineEffect16.Append(presetLineDashProperties16);
            textOutlineEffect16.Append(roundEmpty16);

            W14.FillTextEffect fillTextEffect15 = new W14.FillTextEffect();

            W14.SolidColorFillProperties solidColorFillProperties31 = new W14.SolidColorFillProperties();
            W14.RgbColorModelHex rgbColorModelHex28 = new W14.RgbColorModelHex() { Val = "FFFFFF" };

            solidColorFillProperties31.Append(rgbColorModelHex28);

            fillTextEffect15.Append(solidColorFillProperties31);

            paragraphMarkRunProperties11.Append(bold16);
            paragraphMarkRunProperties11.Append(outline15);
            paragraphMarkRunProperties11.Append(color16);
            paragraphMarkRunProperties11.Append(fontSize16);
            paragraphMarkRunProperties11.Append(fontSizeComplexScript16);
            paragraphMarkRunProperties11.Append(shadow16);
            paragraphMarkRunProperties11.Append(reflection13);
            paragraphMarkRunProperties11.Append(textOutlineEffect16);
            paragraphMarkRunProperties11.Append(fillTextEffect15);

            paragraphProperties12.Append(paragraphMarkRunProperties11);

            paragraph12.Append(paragraphProperties12);

            tableCell10.Append(tableCellProperties10);
            tableCell10.Append(paragraph12);

            TableCell tableCell11 = new TableCell();

            TableCellProperties tableCellProperties11 = new TableCellProperties();
            TableCellWidth tableCellWidth11 = new TableCellWidth() { Width = "2336", Type = TableWidthUnitValues.Dxa };

            tableCellProperties11.Append(tableCellWidth11);

            Paragraph paragraph13 = new Paragraph() { RsidParagraphMarkRevision = "00827FBB", RsidParagraphAddition = "00827FBB", RsidRunAdditionDefault = "00827FBB", ParagraphId = "72556BB6", TextId = "77777777" };

            ParagraphProperties paragraphProperties13 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties12 = new ParagraphMarkRunProperties();
            Bold bold17 = new Bold();
            Outline outline16 = new Outline();
            Color color17 = new Color() { Val = "ED7D31", ThemeColor = ThemeColorValues.Accent2 };
            FontSize fontSize17 = new FontSize() { Val = "144" };
            FontSizeComplexScript fontSizeComplexScript17 = new FontSizeComplexScript() { Val = "144" };

            W14.Shadow shadow17 = new W14.Shadow() { BlurRadius = 63500L, DistanceFromText = 50800L, DirectionAngle = 0, HorizontalScalingFactor = 0, VerticalScalingFactor = 0, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.None };

            W14.RgbColorModelHex rgbColorModelHex29 = new W14.RgbColorModelHex() { Val = "000000" };
            W14.Alpha alpha14 = new W14.Alpha() { Val = 50000 };

            rgbColorModelHex29.Append(alpha14);

            shadow17.Append(rgbColorModelHex29);
            W14.Reflection reflection14 = new W14.Reflection() { BlurRadius = 6350L, StartingOpacity = 55000, StartPosition = 0, EndingOpacity = 300, EndPosition = 45500, DistanceFromText = 0L, DirectionAngle = 5400000, FadeDirection = 5400000, HorizontalScalingFactor = 100000, VerticalScalingFactor = -100000, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.BottomLeft };

            W14.TextOutlineEffect textOutlineEffect17 = new W14.TextOutlineEffect() { LineWidth = 6604, CapType = W14.LineCapValues.Flat, Compound = W14.CompoundLineValues.Simple, Alignment = W14.PenAlignmentValues.Center };

            W14.SolidColorFillProperties solidColorFillProperties32 = new W14.SolidColorFillProperties();
            W14.SchemeColor schemeColor20 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            solidColorFillProperties32.Append(schemeColor20);
            W14.PresetLineDashProperties presetLineDashProperties17 = new W14.PresetLineDashProperties() { Val = W14.PresetLineDashValues.Solid };
            W14.RoundEmpty roundEmpty17 = new W14.RoundEmpty();

            textOutlineEffect17.Append(solidColorFillProperties32);
            textOutlineEffect17.Append(presetLineDashProperties17);
            textOutlineEffect17.Append(roundEmpty17);

            W14.FillTextEffect fillTextEffect16 = new W14.FillTextEffect();

            W14.SolidColorFillProperties solidColorFillProperties33 = new W14.SolidColorFillProperties();
            W14.RgbColorModelHex rgbColorModelHex30 = new W14.RgbColorModelHex() { Val = "FFFFFF" };

            solidColorFillProperties33.Append(rgbColorModelHex30);

            fillTextEffect16.Append(solidColorFillProperties33);

            paragraphMarkRunProperties12.Append(bold17);
            paragraphMarkRunProperties12.Append(outline16);
            paragraphMarkRunProperties12.Append(color17);
            paragraphMarkRunProperties12.Append(fontSize17);
            paragraphMarkRunProperties12.Append(fontSizeComplexScript17);
            paragraphMarkRunProperties12.Append(shadow17);
            paragraphMarkRunProperties12.Append(reflection14);
            paragraphMarkRunProperties12.Append(textOutlineEffect17);
            paragraphMarkRunProperties12.Append(fillTextEffect16);

            paragraphProperties13.Append(paragraphMarkRunProperties12);

            paragraph13.Append(paragraphProperties13);

            tableCell11.Append(tableCellProperties11);
            tableCell11.Append(paragraph13);

            TableCell tableCell12 = new TableCell();

            TableCellProperties tableCellProperties12 = new TableCellProperties();
            TableCellWidth tableCellWidth12 = new TableCellWidth() { Width = "2337", Type = TableWidthUnitValues.Dxa };

            tableCellProperties12.Append(tableCellWidth12);

            Paragraph paragraph14 = new Paragraph() { RsidParagraphMarkRevision = "00827FBB", RsidParagraphAddition = "00827FBB", RsidRunAdditionDefault = "00827FBB", ParagraphId = "521210B7", TextId = "77777777" };

            ParagraphProperties paragraphProperties14 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties13 = new ParagraphMarkRunProperties();
            Bold bold18 = new Bold();
            Outline outline17 = new Outline();
            Color color18 = new Color() { Val = "ED7D31", ThemeColor = ThemeColorValues.Accent2 };
            FontSize fontSize18 = new FontSize() { Val = "144" };
            FontSizeComplexScript fontSizeComplexScript18 = new FontSizeComplexScript() { Val = "144" };

            W14.Shadow shadow18 = new W14.Shadow() { BlurRadius = 63500L, DistanceFromText = 50800L, DirectionAngle = 0, HorizontalScalingFactor = 0, VerticalScalingFactor = 0, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.None };

            W14.RgbColorModelHex rgbColorModelHex31 = new W14.RgbColorModelHex() { Val = "000000" };
            W14.Alpha alpha15 = new W14.Alpha() { Val = 50000 };

            rgbColorModelHex31.Append(alpha15);

            shadow18.Append(rgbColorModelHex31);
            W14.Reflection reflection15 = new W14.Reflection() { BlurRadius = 6350L, StartingOpacity = 55000, StartPosition = 0, EndingOpacity = 300, EndPosition = 45500, DistanceFromText = 0L, DirectionAngle = 5400000, FadeDirection = 5400000, HorizontalScalingFactor = 100000, VerticalScalingFactor = -100000, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.BottomLeft };

            W14.TextOutlineEffect textOutlineEffect18 = new W14.TextOutlineEffect() { LineWidth = 6604, CapType = W14.LineCapValues.Flat, Compound = W14.CompoundLineValues.Simple, Alignment = W14.PenAlignmentValues.Center };

            W14.SolidColorFillProperties solidColorFillProperties34 = new W14.SolidColorFillProperties();
            W14.SchemeColor schemeColor21 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            solidColorFillProperties34.Append(schemeColor21);
            W14.PresetLineDashProperties presetLineDashProperties18 = new W14.PresetLineDashProperties() { Val = W14.PresetLineDashValues.Solid };
            W14.RoundEmpty roundEmpty18 = new W14.RoundEmpty();

            textOutlineEffect18.Append(solidColorFillProperties34);
            textOutlineEffect18.Append(presetLineDashProperties18);
            textOutlineEffect18.Append(roundEmpty18);

            W14.FillTextEffect fillTextEffect17 = new W14.FillTextEffect();

            W14.SolidColorFillProperties solidColorFillProperties35 = new W14.SolidColorFillProperties();
            W14.RgbColorModelHex rgbColorModelHex32 = new W14.RgbColorModelHex() { Val = "FFFFFF" };

            solidColorFillProperties35.Append(rgbColorModelHex32);

            fillTextEffect17.Append(solidColorFillProperties35);

            paragraphMarkRunProperties13.Append(bold18);
            paragraphMarkRunProperties13.Append(outline17);
            paragraphMarkRunProperties13.Append(color18);
            paragraphMarkRunProperties13.Append(fontSize18);
            paragraphMarkRunProperties13.Append(fontSizeComplexScript18);
            paragraphMarkRunProperties13.Append(shadow18);
            paragraphMarkRunProperties13.Append(reflection15);
            paragraphMarkRunProperties13.Append(textOutlineEffect18);
            paragraphMarkRunProperties13.Append(fillTextEffect17);

            paragraphProperties14.Append(paragraphMarkRunProperties13);

            paragraph14.Append(paragraphProperties14);

            tableCell12.Append(tableCellProperties12);
            tableCell12.Append(paragraph14);

            tableRow3.Append(tableCell9);
            tableRow3.Append(tableCell10);
            tableRow3.Append(tableCell11);
            tableRow3.Append(tableCell12);

            table1.Append(tableProperties1);
            table1.Append(tableGrid1);
            table1.Append(tableRow1);
            table1.Append(tableRow2);
            table1.Append(tableRow3);

            Paragraph paragraph15 = new Paragraph() { RsidParagraphMarkRevision = "00827FBB", RsidParagraphAddition = "00827FBB", RsidRunAdditionDefault = "00827FBB", ParagraphId = "2DC4CADA", TextId = "77777777" };

            ParagraphProperties paragraphProperties15 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties14 = new ParagraphMarkRunProperties();
            Bold bold19 = new Bold();
            Outline outline18 = new Outline();
            Color color19 = new Color() { Val = "ED7D31", ThemeColor = ThemeColorValues.Accent2 };
            FontSize fontSize19 = new FontSize() { Val = "144" };
            FontSizeComplexScript fontSizeComplexScript19 = new FontSizeComplexScript() { Val = "144" };

            W14.Shadow shadow19 = new W14.Shadow() { BlurRadius = 0L, DistanceFromText = 38100L, DirectionAngle = 2700000, HorizontalScalingFactor = 100000, VerticalScalingFactor = 100000, HorizontalSkewAngle = 0, VerticalSkewAngle = 0, Alignment = W14.RectangleAlignmentValues.TopLeft };
            W14.SchemeColor schemeColor22 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            shadow19.Append(schemeColor22);

            W14.TextOutlineEffect textOutlineEffect19 = new W14.TextOutlineEffect() { LineWidth = 6604, CapType = W14.LineCapValues.Flat, Compound = W14.CompoundLineValues.Simple, Alignment = W14.PenAlignmentValues.Center };

            W14.SolidColorFillProperties solidColorFillProperties36 = new W14.SolidColorFillProperties();
            W14.SchemeColor schemeColor23 = new W14.SchemeColor() { Val = W14.SchemeColorValues.ExtraSchemeColor2 };

            solidColorFillProperties36.Append(schemeColor23);
            W14.PresetLineDashProperties presetLineDashProperties19 = new W14.PresetLineDashProperties() { Val = W14.PresetLineDashValues.Solid };
            W14.RoundEmpty roundEmpty19 = new W14.RoundEmpty();

            textOutlineEffect19.Append(solidColorFillProperties36);
            textOutlineEffect19.Append(presetLineDashProperties19);
            textOutlineEffect19.Append(roundEmpty19);

            W14.FillTextEffect fillTextEffect18 = new W14.FillTextEffect();

            W14.SolidColorFillProperties solidColorFillProperties37 = new W14.SolidColorFillProperties();
            W14.RgbColorModelHex rgbColorModelHex33 = new W14.RgbColorModelHex() { Val = "FFFFFF" };

            solidColorFillProperties37.Append(rgbColorModelHex33);

            fillTextEffect18.Append(solidColorFillProperties37);

            paragraphMarkRunProperties14.Append(bold19);
            paragraphMarkRunProperties14.Append(outline18);
            paragraphMarkRunProperties14.Append(color19);
            paragraphMarkRunProperties14.Append(fontSize19);
            paragraphMarkRunProperties14.Append(fontSizeComplexScript19);
            paragraphMarkRunProperties14.Append(shadow19);
            paragraphMarkRunProperties14.Append(textOutlineEffect19);
            paragraphMarkRunProperties14.Append(fillTextEffect18);

            paragraphProperties15.Append(paragraphMarkRunProperties14);

            paragraph15.Append(paragraphProperties15);

            SectionProperties sectionProperties1 = new SectionProperties() { RsidRPr = "00827FBB", RsidR = "00827FBB" };
            PageSize pageSize1 = new PageSize() { Width = (UInt32Value)11906U, Height = (UInt32Value)16838U };
            PageMargin pageMargin1 = new PageMargin() { Top = 1134, Right = (UInt32Value)850U, Bottom = 1134, Left = (UInt32Value)1701U, Header = (UInt32Value)708U, Footer = (UInt32Value)708U, Gutter = (UInt32Value)0U };
            Columns columns1 = new Columns() { Space = "708" };
            DocGrid docGrid1 = new DocGrid() { LinePitch = 360 };

            sectionProperties1.Append(pageSize1);
            sectionProperties1.Append(pageMargin1);
            sectionProperties1.Append(columns1);
            sectionProperties1.Append(docGrid1);

            body1.Append(paragraph1);
            body1.Append(paragraph2);
            body1.Append(table1);
            body1.Append(paragraph15);
            body1.Append(sectionProperties1);

            document1.Append(body1);

            mainDocumentPart1.Document = document1;
        }

        // Generates content of webSettingsPart1.
        private void GenerateWebSettingsPart1Content(WebSettingsPart webSettingsPart1)
        {
            WebSettings webSettings1 = new WebSettings() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 w15 w16se w16cid" } };
            webSettings1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            webSettings1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            webSettings1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            webSettings1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            webSettings1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");
            webSettings1.AddNamespaceDeclaration("w16cid", "http://schemas.microsoft.com/office/word/2016/wordml/cid");
            webSettings1.AddNamespaceDeclaration("w16se", "http://schemas.microsoft.com/office/word/2015/wordml/symex");
            OptimizeForBrowser optimizeForBrowser1 = new OptimizeForBrowser();
            AllowPNG allowPNG1 = new AllowPNG();

            webSettings1.Append(optimizeForBrowser1);
            webSettings1.Append(allowPNG1);

            webSettingsPart1.WebSettings = webSettings1;
        }

        // Generates content of documentSettingsPart1.
        private void GenerateDocumentSettingsPart1Content(DocumentSettingsPart documentSettingsPart1)
        {
            Settings settings1 = new Settings() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 w15 w16se w16cid" } };
            settings1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            settings1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            settings1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            settings1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            settings1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            settings1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            settings1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            settings1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            settings1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");
            settings1.AddNamespaceDeclaration("w16cid", "http://schemas.microsoft.com/office/word/2016/wordml/cid");
            settings1.AddNamespaceDeclaration("w16se", "http://schemas.microsoft.com/office/word/2015/wordml/symex");
            settings1.AddNamespaceDeclaration("sl", "http://schemas.openxmlformats.org/schemaLibrary/2006/main");
            Zoom zoom1 = new Zoom() { Percent = "100" };
            ProofState proofState1 = new ProofState() { Spelling = ProofingStateValues.Clean, Grammar = ProofingStateValues.Clean };
            DefaultTabStop defaultTabStop1 = new DefaultTabStop() { Val = 708 };
            CharacterSpacingControl characterSpacingControl1 = new CharacterSpacingControl() { Val = CharacterSpacingValues.DoNotCompress };

            Compatibility compatibility1 = new Compatibility();
            CompatibilitySetting compatibilitySetting1 = new CompatibilitySetting() { Name = CompatSettingNameValues.CompatibilityMode, Uri = "http://schemas.microsoft.com/office/word", Val = "15" };
            CompatibilitySetting compatibilitySetting2 = new CompatibilitySetting() { Name = CompatSettingNameValues.OverrideTableStyleFontSizeAndJustification, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting3 = new CompatibilitySetting() { Name = CompatSettingNameValues.EnableOpenTypeFeatures, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting4 = new CompatibilitySetting() { Name = CompatSettingNameValues.DoNotFlipMirrorIndents, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting5 = new CompatibilitySetting() { Name = CompatSettingNameValues.DifferentiateMultirowTableHeaders, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting6 = new CompatibilitySetting() { Name = new EnumValue<CompatSettingNameValues>() { InnerText = "useWord2013TrackBottomHyphenation" }, Uri = "http://schemas.microsoft.com/office/word", Val = "0" };

            compatibility1.Append(compatibilitySetting1);
            compatibility1.Append(compatibilitySetting2);
            compatibility1.Append(compatibilitySetting3);
            compatibility1.Append(compatibilitySetting4);
            compatibility1.Append(compatibilitySetting5);
            compatibility1.Append(compatibilitySetting6);

            Rsids rsids1 = new Rsids();
            RsidRoot rsidRoot1 = new RsidRoot() { Val = "003E4A2B" };
            Rsid rsid1 = new Rsid() { Val = "003E4A2B" };
            Rsid rsid2 = new Rsid() { Val = "00732A61" };
            Rsid rsid3 = new Rsid() { Val = "00827FBB" };

            rsids1.Append(rsidRoot1);
            rsids1.Append(rsid1);
            rsids1.Append(rsid2);
            rsids1.Append(rsid3);

            M.MathProperties mathProperties1 = new M.MathProperties();
            M.MathFont mathFont1 = new M.MathFont() { Val = "Cambria Math" };
            M.BreakBinary breakBinary1 = new M.BreakBinary() { Val = M.BreakBinaryOperatorValues.Before };
            M.BreakBinarySubtraction breakBinarySubtraction1 = new M.BreakBinarySubtraction() { Val = M.BreakBinarySubtractionValues.MinusMinus };
            M.SmallFraction smallFraction1 = new M.SmallFraction() { Val = M.BooleanValues.Zero };
            M.DisplayDefaults displayDefaults1 = new M.DisplayDefaults();
            M.LeftMargin leftMargin1 = new M.LeftMargin() { Val = (UInt32Value)0U };
            M.RightMargin rightMargin1 = new M.RightMargin() { Val = (UInt32Value)0U };
            M.DefaultJustification defaultJustification1 = new M.DefaultJustification() { Val = M.JustificationValues.CenterGroup };
            M.WrapIndent wrapIndent1 = new M.WrapIndent() { Val = (UInt32Value)1440U };
            M.IntegralLimitLocation integralLimitLocation1 = new M.IntegralLimitLocation() { Val = M.LimitLocationValues.SubscriptSuperscript };
            M.NaryLimitLocation naryLimitLocation1 = new M.NaryLimitLocation() { Val = M.LimitLocationValues.UnderOver };

            mathProperties1.Append(mathFont1);
            mathProperties1.Append(breakBinary1);
            mathProperties1.Append(breakBinarySubtraction1);
            mathProperties1.Append(smallFraction1);
            mathProperties1.Append(displayDefaults1);
            mathProperties1.Append(leftMargin1);
            mathProperties1.Append(rightMargin1);
            mathProperties1.Append(defaultJustification1);
            mathProperties1.Append(wrapIndent1);
            mathProperties1.Append(integralLimitLocation1);
            mathProperties1.Append(naryLimitLocation1);
            ThemeFontLanguages themeFontLanguages1 = new ThemeFontLanguages() { Val = "ru-RU" };
            ColorSchemeMapping colorSchemeMapping1 = new ColorSchemeMapping() { Background1 = ColorSchemeIndexValues.Light1, Text1 = ColorSchemeIndexValues.Dark1, Background2 = ColorSchemeIndexValues.Light2, Text2 = ColorSchemeIndexValues.Dark2, Accent1 = ColorSchemeIndexValues.Accent1, Accent2 = ColorSchemeIndexValues.Accent2, Accent3 = ColorSchemeIndexValues.Accent3, Accent4 = ColorSchemeIndexValues.Accent4, Accent5 = ColorSchemeIndexValues.Accent5, Accent6 = ColorSchemeIndexValues.Accent6, Hyperlink = ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = ColorSchemeIndexValues.FollowedHyperlink };

            ShapeDefaults shapeDefaults1 = new ShapeDefaults();
            Ovml.ShapeDefaults shapeDefaults2 = new Ovml.ShapeDefaults() { Extension = V.ExtensionHandlingBehaviorValues.Edit, MaxShapeId = 1026 };

            Ovml.ShapeLayout shapeLayout1 = new Ovml.ShapeLayout() { Extension = V.ExtensionHandlingBehaviorValues.Edit };
            Ovml.ShapeIdMap shapeIdMap1 = new Ovml.ShapeIdMap() { Extension = V.ExtensionHandlingBehaviorValues.Edit, Data = "1" };

            shapeLayout1.Append(shapeIdMap1);

            shapeDefaults1.Append(shapeDefaults2);
            shapeDefaults1.Append(shapeLayout1);
            DecimalSymbol decimalSymbol1 = new DecimalSymbol() { Val = "," };
            ListSeparator listSeparator1 = new ListSeparator() { Val = ";" };
            W14.DocumentId documentId1 = new W14.DocumentId() { Val = "7570F16B" };
            W15.ChartTrackingRefBased chartTrackingRefBased1 = new W15.ChartTrackingRefBased();
            W15.PersistentDocumentId persistentDocumentId1 = new W15.PersistentDocumentId() { Val = "{4BF19718-10E4-4AFE-A1D5-70C6B49DCDFF}" };

            settings1.Append(zoom1);
            settings1.Append(proofState1);
            settings1.Append(defaultTabStop1);
            settings1.Append(characterSpacingControl1);
            settings1.Append(compatibility1);
            settings1.Append(rsids1);
            settings1.Append(mathProperties1);
            settings1.Append(themeFontLanguages1);
            settings1.Append(colorSchemeMapping1);
            settings1.Append(shapeDefaults1);
            settings1.Append(decimalSymbol1);
            settings1.Append(listSeparator1);
            settings1.Append(documentId1);
            settings1.Append(chartTrackingRefBased1);
            settings1.Append(persistentDocumentId1);

            documentSettingsPart1.Settings = settings1;
        }

        // Generates content of styleDefinitionsPart1.
        private void GenerateStyleDefinitionsPart1Content(StyleDefinitionsPart styleDefinitionsPart1)
        {
            Styles styles1 = new Styles() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 w15 w16se w16cid" } };
            styles1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            styles1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            styles1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            styles1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            styles1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");
            styles1.AddNamespaceDeclaration("w16cid", "http://schemas.microsoft.com/office/word/2016/wordml/cid");
            styles1.AddNamespaceDeclaration("w16se", "http://schemas.microsoft.com/office/word/2015/wordml/symex");

            DocDefaults docDefaults1 = new DocDefaults();

            RunPropertiesDefault runPropertiesDefault1 = new RunPropertiesDefault();

            RunPropertiesBaseStyle runPropertiesBaseStyle1 = new RunPropertiesBaseStyle();
            RunFonts runFonts1 = new RunFonts() { AsciiTheme = ThemeFontValues.MinorHighAnsi, HighAnsiTheme = ThemeFontValues.MinorHighAnsi, EastAsiaTheme = ThemeFontValues.MinorHighAnsi, ComplexScriptTheme = ThemeFontValues.MinorBidi };
            FontSize fontSize20 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript20 = new FontSizeComplexScript() { Val = "22" };
            Languages languages7 = new Languages() { Val = "ru-RU", EastAsia = "en-US", Bidi = "ar-SA" };

            runPropertiesBaseStyle1.Append(runFonts1);
            runPropertiesBaseStyle1.Append(fontSize20);
            runPropertiesBaseStyle1.Append(fontSizeComplexScript20);
            runPropertiesBaseStyle1.Append(languages7);

            runPropertiesDefault1.Append(runPropertiesBaseStyle1);

            ParagraphPropertiesDefault paragraphPropertiesDefault1 = new ParagraphPropertiesDefault();

            ParagraphPropertiesBaseStyle paragraphPropertiesBaseStyle1 = new ParagraphPropertiesBaseStyle();
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines() { After = "160", Line = "259", LineRule = LineSpacingRuleValues.Auto };

            paragraphPropertiesBaseStyle1.Append(spacingBetweenLines1);

            paragraphPropertiesDefault1.Append(paragraphPropertiesBaseStyle1);

            docDefaults1.Append(runPropertiesDefault1);
            docDefaults1.Append(paragraphPropertiesDefault1);

            LatentStyles latentStyles1 = new LatentStyles() { DefaultLockedState = false, DefaultUiPriority = 99, DefaultSemiHidden = false, DefaultUnhideWhenUsed = false, DefaultPrimaryStyle = false, Count = 377 };
            LatentStyleExceptionInfo latentStyleExceptionInfo1 = new LatentStyleExceptionInfo() { Name = "Normal", UiPriority = 0, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo2 = new LatentStyleExceptionInfo() { Name = "heading 1", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo3 = new LatentStyleExceptionInfo() { Name = "heading 2", UiPriority = 9, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo4 = new LatentStyleExceptionInfo() { Name = "heading 3", UiPriority = 9, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo5 = new LatentStyleExceptionInfo() { Name = "heading 4", UiPriority = 9, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo6 = new LatentStyleExceptionInfo() { Name = "heading 5", UiPriority = 9, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo7 = new LatentStyleExceptionInfo() { Name = "heading 6", UiPriority = 9, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo8 = new LatentStyleExceptionInfo() { Name = "heading 7", UiPriority = 9, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo9 = new LatentStyleExceptionInfo() { Name = "heading 8", UiPriority = 9, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo10 = new LatentStyleExceptionInfo() { Name = "heading 9", UiPriority = 9, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo11 = new LatentStyleExceptionInfo() { Name = "index 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo12 = new LatentStyleExceptionInfo() { Name = "index 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo13 = new LatentStyleExceptionInfo() { Name = "index 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo14 = new LatentStyleExceptionInfo() { Name = "index 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo15 = new LatentStyleExceptionInfo() { Name = "index 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo16 = new LatentStyleExceptionInfo() { Name = "index 6", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo17 = new LatentStyleExceptionInfo() { Name = "index 7", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo18 = new LatentStyleExceptionInfo() { Name = "index 8", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo19 = new LatentStyleExceptionInfo() { Name = "index 9", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo20 = new LatentStyleExceptionInfo() { Name = "toc 1", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo21 = new LatentStyleExceptionInfo() { Name = "toc 2", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo22 = new LatentStyleExceptionInfo() { Name = "toc 3", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo23 = new LatentStyleExceptionInfo() { Name = "toc 4", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo24 = new LatentStyleExceptionInfo() { Name = "toc 5", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo25 = new LatentStyleExceptionInfo() { Name = "toc 6", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo26 = new LatentStyleExceptionInfo() { Name = "toc 7", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo27 = new LatentStyleExceptionInfo() { Name = "toc 8", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo28 = new LatentStyleExceptionInfo() { Name = "toc 9", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo29 = new LatentStyleExceptionInfo() { Name = "Normal Indent", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo30 = new LatentStyleExceptionInfo() { Name = "footnote text", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo31 = new LatentStyleExceptionInfo() { Name = "annotation text", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo32 = new LatentStyleExceptionInfo() { Name = "header", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo33 = new LatentStyleExceptionInfo() { Name = "footer", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo34 = new LatentStyleExceptionInfo() { Name = "index heading", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo35 = new LatentStyleExceptionInfo() { Name = "caption", UiPriority = 35, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo36 = new LatentStyleExceptionInfo() { Name = "table of figures", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo37 = new LatentStyleExceptionInfo() { Name = "envelope address", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo38 = new LatentStyleExceptionInfo() { Name = "envelope return", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo39 = new LatentStyleExceptionInfo() { Name = "footnote reference", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo40 = new LatentStyleExceptionInfo() { Name = "annotation reference", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo41 = new LatentStyleExceptionInfo() { Name = "line number", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo42 = new LatentStyleExceptionInfo() { Name = "page number", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo43 = new LatentStyleExceptionInfo() { Name = "endnote reference", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo44 = new LatentStyleExceptionInfo() { Name = "endnote text", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo45 = new LatentStyleExceptionInfo() { Name = "table of authorities", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo46 = new LatentStyleExceptionInfo() { Name = "macro", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo47 = new LatentStyleExceptionInfo() { Name = "toa heading", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo48 = new LatentStyleExceptionInfo() { Name = "List", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo49 = new LatentStyleExceptionInfo() { Name = "List Bullet", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo50 = new LatentStyleExceptionInfo() { Name = "List Number", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo51 = new LatentStyleExceptionInfo() { Name = "List 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo52 = new LatentStyleExceptionInfo() { Name = "List 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo53 = new LatentStyleExceptionInfo() { Name = "List 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo54 = new LatentStyleExceptionInfo() { Name = "List 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo55 = new LatentStyleExceptionInfo() { Name = "List Bullet 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo56 = new LatentStyleExceptionInfo() { Name = "List Bullet 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo57 = new LatentStyleExceptionInfo() { Name = "List Bullet 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo58 = new LatentStyleExceptionInfo() { Name = "List Bullet 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo59 = new LatentStyleExceptionInfo() { Name = "List Number 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo60 = new LatentStyleExceptionInfo() { Name = "List Number 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo61 = new LatentStyleExceptionInfo() { Name = "List Number 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo62 = new LatentStyleExceptionInfo() { Name = "List Number 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo63 = new LatentStyleExceptionInfo() { Name = "Title", UiPriority = 10, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo64 = new LatentStyleExceptionInfo() { Name = "Closing", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo65 = new LatentStyleExceptionInfo() { Name = "Signature", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo66 = new LatentStyleExceptionInfo() { Name = "Default Paragraph Font", UiPriority = 1, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo67 = new LatentStyleExceptionInfo() { Name = "Body Text", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo68 = new LatentStyleExceptionInfo() { Name = "Body Text Indent", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo69 = new LatentStyleExceptionInfo() { Name = "List Continue", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo70 = new LatentStyleExceptionInfo() { Name = "List Continue 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo71 = new LatentStyleExceptionInfo() { Name = "List Continue 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo72 = new LatentStyleExceptionInfo() { Name = "List Continue 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo73 = new LatentStyleExceptionInfo() { Name = "List Continue 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo74 = new LatentStyleExceptionInfo() { Name = "Message Header", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo75 = new LatentStyleExceptionInfo() { Name = "Subtitle", UiPriority = 11, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo76 = new LatentStyleExceptionInfo() { Name = "Salutation", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo77 = new LatentStyleExceptionInfo() { Name = "Date", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo78 = new LatentStyleExceptionInfo() { Name = "Body Text First Indent", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo79 = new LatentStyleExceptionInfo() { Name = "Body Text First Indent 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo80 = new LatentStyleExceptionInfo() { Name = "Note Heading", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo81 = new LatentStyleExceptionInfo() { Name = "Body Text 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo82 = new LatentStyleExceptionInfo() { Name = "Body Text 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo83 = new LatentStyleExceptionInfo() { Name = "Body Text Indent 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo84 = new LatentStyleExceptionInfo() { Name = "Body Text Indent 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo85 = new LatentStyleExceptionInfo() { Name = "Block Text", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo86 = new LatentStyleExceptionInfo() { Name = "Hyperlink", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo87 = new LatentStyleExceptionInfo() { Name = "FollowedHyperlink", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo88 = new LatentStyleExceptionInfo() { Name = "Strong", UiPriority = 22, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo89 = new LatentStyleExceptionInfo() { Name = "Emphasis", UiPriority = 20, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo90 = new LatentStyleExceptionInfo() { Name = "Document Map", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo91 = new LatentStyleExceptionInfo() { Name = "Plain Text", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo92 = new LatentStyleExceptionInfo() { Name = "E-mail Signature", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo93 = new LatentStyleExceptionInfo() { Name = "HTML Top of Form", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo94 = new LatentStyleExceptionInfo() { Name = "HTML Bottom of Form", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo95 = new LatentStyleExceptionInfo() { Name = "Normal (Web)", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo96 = new LatentStyleExceptionInfo() { Name = "HTML Acronym", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo97 = new LatentStyleExceptionInfo() { Name = "HTML Address", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo98 = new LatentStyleExceptionInfo() { Name = "HTML Cite", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo99 = new LatentStyleExceptionInfo() { Name = "HTML Code", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo100 = new LatentStyleExceptionInfo() { Name = "HTML Definition", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo101 = new LatentStyleExceptionInfo() { Name = "HTML Keyboard", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo102 = new LatentStyleExceptionInfo() { Name = "HTML Preformatted", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo103 = new LatentStyleExceptionInfo() { Name = "HTML Sample", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo104 = new LatentStyleExceptionInfo() { Name = "HTML Typewriter", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo105 = new LatentStyleExceptionInfo() { Name = "HTML Variable", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo106 = new LatentStyleExceptionInfo() { Name = "annotation subject", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo107 = new LatentStyleExceptionInfo() { Name = "No List", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo108 = new LatentStyleExceptionInfo() { Name = "Outline List 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo109 = new LatentStyleExceptionInfo() { Name = "Outline List 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo110 = new LatentStyleExceptionInfo() { Name = "Outline List 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo111 = new LatentStyleExceptionInfo() { Name = "Table Simple 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo112 = new LatentStyleExceptionInfo() { Name = "Table Simple 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo113 = new LatentStyleExceptionInfo() { Name = "Table Simple 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo114 = new LatentStyleExceptionInfo() { Name = "Table Classic 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo115 = new LatentStyleExceptionInfo() { Name = "Table Classic 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo116 = new LatentStyleExceptionInfo() { Name = "Table Classic 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo117 = new LatentStyleExceptionInfo() { Name = "Table Classic 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo118 = new LatentStyleExceptionInfo() { Name = "Table Colorful 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo119 = new LatentStyleExceptionInfo() { Name = "Table Colorful 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo120 = new LatentStyleExceptionInfo() { Name = "Table Colorful 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo121 = new LatentStyleExceptionInfo() { Name = "Table Columns 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo122 = new LatentStyleExceptionInfo() { Name = "Table Columns 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo123 = new LatentStyleExceptionInfo() { Name = "Table Columns 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo124 = new LatentStyleExceptionInfo() { Name = "Table Columns 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo125 = new LatentStyleExceptionInfo() { Name = "Table Columns 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo126 = new LatentStyleExceptionInfo() { Name = "Table Grid 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo127 = new LatentStyleExceptionInfo() { Name = "Table Grid 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo128 = new LatentStyleExceptionInfo() { Name = "Table Grid 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo129 = new LatentStyleExceptionInfo() { Name = "Table Grid 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo130 = new LatentStyleExceptionInfo() { Name = "Table Grid 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo131 = new LatentStyleExceptionInfo() { Name = "Table Grid 6", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo132 = new LatentStyleExceptionInfo() { Name = "Table Grid 7", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo133 = new LatentStyleExceptionInfo() { Name = "Table Grid 8", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo134 = new LatentStyleExceptionInfo() { Name = "Table List 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo135 = new LatentStyleExceptionInfo() { Name = "Table List 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo136 = new LatentStyleExceptionInfo() { Name = "Table List 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo137 = new LatentStyleExceptionInfo() { Name = "Table List 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo138 = new LatentStyleExceptionInfo() { Name = "Table List 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo139 = new LatentStyleExceptionInfo() { Name = "Table List 6", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo140 = new LatentStyleExceptionInfo() { Name = "Table List 7", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo141 = new LatentStyleExceptionInfo() { Name = "Table List 8", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo142 = new LatentStyleExceptionInfo() { Name = "Table 3D effects 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo143 = new LatentStyleExceptionInfo() { Name = "Table 3D effects 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo144 = new LatentStyleExceptionInfo() { Name = "Table 3D effects 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo145 = new LatentStyleExceptionInfo() { Name = "Table Contemporary", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo146 = new LatentStyleExceptionInfo() { Name = "Table Elegant", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo147 = new LatentStyleExceptionInfo() { Name = "Table Professional", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo148 = new LatentStyleExceptionInfo() { Name = "Table Subtle 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo149 = new LatentStyleExceptionInfo() { Name = "Table Subtle 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo150 = new LatentStyleExceptionInfo() { Name = "Table Web 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo151 = new LatentStyleExceptionInfo() { Name = "Table Web 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo152 = new LatentStyleExceptionInfo() { Name = "Balloon Text", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo153 = new LatentStyleExceptionInfo() { Name = "Table Grid", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo154 = new LatentStyleExceptionInfo() { Name = "Placeholder Text", SemiHidden = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo155 = new LatentStyleExceptionInfo() { Name = "No Spacing", UiPriority = 1, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo156 = new LatentStyleExceptionInfo() { Name = "Light Shading", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo157 = new LatentStyleExceptionInfo() { Name = "Light List", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo158 = new LatentStyleExceptionInfo() { Name = "Light Grid", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo159 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo160 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo161 = new LatentStyleExceptionInfo() { Name = "Medium List 1", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo162 = new LatentStyleExceptionInfo() { Name = "Medium List 2", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo163 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo164 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo165 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo166 = new LatentStyleExceptionInfo() { Name = "Dark List", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo167 = new LatentStyleExceptionInfo() { Name = "Colorful Shading", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo168 = new LatentStyleExceptionInfo() { Name = "Colorful List", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo169 = new LatentStyleExceptionInfo() { Name = "Colorful Grid", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo170 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 1", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo171 = new LatentStyleExceptionInfo() { Name = "Light List Accent 1", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo172 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 1", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo173 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 1", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo174 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 1", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo175 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 1", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo176 = new LatentStyleExceptionInfo() { Name = "Revision", SemiHidden = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo177 = new LatentStyleExceptionInfo() { Name = "List Paragraph", UiPriority = 34, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo178 = new LatentStyleExceptionInfo() { Name = "Quote", UiPriority = 29, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo179 = new LatentStyleExceptionInfo() { Name = "Intense Quote", UiPriority = 30, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo180 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 1", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo181 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 1", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo182 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 1", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo183 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 1", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo184 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 1", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo185 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 1", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo186 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 1", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo187 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 1", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo188 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 2", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo189 = new LatentStyleExceptionInfo() { Name = "Light List Accent 2", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo190 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 2", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo191 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 2", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo192 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 2", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo193 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 2", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo194 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 2", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo195 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 2", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo196 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 2", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo197 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 2", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo198 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 2", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo199 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 2", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo200 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 2", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo201 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 2", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo202 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 3", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo203 = new LatentStyleExceptionInfo() { Name = "Light List Accent 3", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo204 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 3", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo205 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 3", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo206 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 3", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo207 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 3", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo208 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 3", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo209 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 3", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo210 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 3", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo211 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 3", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo212 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 3", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo213 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 3", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo214 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 3", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo215 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 3", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo216 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 4", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo217 = new LatentStyleExceptionInfo() { Name = "Light List Accent 4", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo218 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 4", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo219 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 4", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo220 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 4", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo221 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 4", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo222 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 4", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo223 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 4", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo224 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 4", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo225 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 4", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo226 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 4", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo227 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 4", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo228 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 4", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo229 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 4", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo230 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 5", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo231 = new LatentStyleExceptionInfo() { Name = "Light List Accent 5", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo232 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 5", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo233 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 5", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo234 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 5", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo235 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 5", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo236 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 5", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo237 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 5", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo238 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 5", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo239 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 5", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo240 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 5", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo241 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 5", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo242 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 5", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo243 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 5", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo244 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 6", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo245 = new LatentStyleExceptionInfo() { Name = "Light List Accent 6", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo246 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 6", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo247 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 6", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo248 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 6", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo249 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 6", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo250 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 6", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo251 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 6", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo252 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 6", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo253 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 6", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo254 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 6", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo255 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 6", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo256 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 6", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo257 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 6", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo258 = new LatentStyleExceptionInfo() { Name = "Subtle Emphasis", UiPriority = 19, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo259 = new LatentStyleExceptionInfo() { Name = "Intense Emphasis", UiPriority = 21, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo260 = new LatentStyleExceptionInfo() { Name = "Subtle Reference", UiPriority = 31, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo261 = new LatentStyleExceptionInfo() { Name = "Intense Reference", UiPriority = 32, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo262 = new LatentStyleExceptionInfo() { Name = "Book Title", UiPriority = 33, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo263 = new LatentStyleExceptionInfo() { Name = "Bibliography", UiPriority = 37, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo264 = new LatentStyleExceptionInfo() { Name = "TOC Heading", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo265 = new LatentStyleExceptionInfo() { Name = "Plain Table 1", UiPriority = 41 };
            LatentStyleExceptionInfo latentStyleExceptionInfo266 = new LatentStyleExceptionInfo() { Name = "Plain Table 2", UiPriority = 42 };
            LatentStyleExceptionInfo latentStyleExceptionInfo267 = new LatentStyleExceptionInfo() { Name = "Plain Table 3", UiPriority = 43 };
            LatentStyleExceptionInfo latentStyleExceptionInfo268 = new LatentStyleExceptionInfo() { Name = "Plain Table 4", UiPriority = 44 };
            LatentStyleExceptionInfo latentStyleExceptionInfo269 = new LatentStyleExceptionInfo() { Name = "Plain Table 5", UiPriority = 45 };
            LatentStyleExceptionInfo latentStyleExceptionInfo270 = new LatentStyleExceptionInfo() { Name = "Grid Table Light", UiPriority = 40 };
            LatentStyleExceptionInfo latentStyleExceptionInfo271 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo272 = new LatentStyleExceptionInfo() { Name = "Grid Table 2", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo273 = new LatentStyleExceptionInfo() { Name = "Grid Table 3", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo274 = new LatentStyleExceptionInfo() { Name = "Grid Table 4", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo275 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo276 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo277 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo278 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light Accent 1", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo279 = new LatentStyleExceptionInfo() { Name = "Grid Table 2 Accent 1", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo280 = new LatentStyleExceptionInfo() { Name = "Grid Table 3 Accent 1", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo281 = new LatentStyleExceptionInfo() { Name = "Grid Table 4 Accent 1", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo282 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark Accent 1", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo283 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful Accent 1", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo284 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful Accent 1", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo285 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light Accent 2", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo286 = new LatentStyleExceptionInfo() { Name = "Grid Table 2 Accent 2", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo287 = new LatentStyleExceptionInfo() { Name = "Grid Table 3 Accent 2", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo288 = new LatentStyleExceptionInfo() { Name = "Grid Table 4 Accent 2", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo289 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark Accent 2", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo290 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful Accent 2", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo291 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful Accent 2", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo292 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light Accent 3", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo293 = new LatentStyleExceptionInfo() { Name = "Grid Table 2 Accent 3", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo294 = new LatentStyleExceptionInfo() { Name = "Grid Table 3 Accent 3", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo295 = new LatentStyleExceptionInfo() { Name = "Grid Table 4 Accent 3", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo296 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark Accent 3", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo297 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful Accent 3", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo298 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful Accent 3", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo299 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light Accent 4", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo300 = new LatentStyleExceptionInfo() { Name = "Grid Table 2 Accent 4", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo301 = new LatentStyleExceptionInfo() { Name = "Grid Table 3 Accent 4", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo302 = new LatentStyleExceptionInfo() { Name = "Grid Table 4 Accent 4", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo303 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark Accent 4", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo304 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful Accent 4", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo305 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful Accent 4", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo306 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light Accent 5", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo307 = new LatentStyleExceptionInfo() { Name = "Grid Table 2 Accent 5", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo308 = new LatentStyleExceptionInfo() { Name = "Grid Table 3 Accent 5", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo309 = new LatentStyleExceptionInfo() { Name = "Grid Table 4 Accent 5", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo310 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark Accent 5", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo311 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful Accent 5", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo312 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful Accent 5", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo313 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light Accent 6", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo314 = new LatentStyleExceptionInfo() { Name = "Grid Table 2 Accent 6", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo315 = new LatentStyleExceptionInfo() { Name = "Grid Table 3 Accent 6", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo316 = new LatentStyleExceptionInfo() { Name = "Grid Table 4 Accent 6", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo317 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark Accent 6", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo318 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful Accent 6", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo319 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful Accent 6", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo320 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo321 = new LatentStyleExceptionInfo() { Name = "List Table 2", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo322 = new LatentStyleExceptionInfo() { Name = "List Table 3", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo323 = new LatentStyleExceptionInfo() { Name = "List Table 4", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo324 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo325 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo326 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo327 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light Accent 1", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo328 = new LatentStyleExceptionInfo() { Name = "List Table 2 Accent 1", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo329 = new LatentStyleExceptionInfo() { Name = "List Table 3 Accent 1", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo330 = new LatentStyleExceptionInfo() { Name = "List Table 4 Accent 1", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo331 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark Accent 1", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo332 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful Accent 1", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo333 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful Accent 1", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo334 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light Accent 2", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo335 = new LatentStyleExceptionInfo() { Name = "List Table 2 Accent 2", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo336 = new LatentStyleExceptionInfo() { Name = "List Table 3 Accent 2", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo337 = new LatentStyleExceptionInfo() { Name = "List Table 4 Accent 2", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo338 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark Accent 2", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo339 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful Accent 2", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo340 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful Accent 2", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo341 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light Accent 3", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo342 = new LatentStyleExceptionInfo() { Name = "List Table 2 Accent 3", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo343 = new LatentStyleExceptionInfo() { Name = "List Table 3 Accent 3", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo344 = new LatentStyleExceptionInfo() { Name = "List Table 4 Accent 3", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo345 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark Accent 3", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo346 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful Accent 3", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo347 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful Accent 3", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo348 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light Accent 4", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo349 = new LatentStyleExceptionInfo() { Name = "List Table 2 Accent 4", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo350 = new LatentStyleExceptionInfo() { Name = "List Table 3 Accent 4", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo351 = new LatentStyleExceptionInfo() { Name = "List Table 4 Accent 4", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo352 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark Accent 4", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo353 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful Accent 4", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo354 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful Accent 4", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo355 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light Accent 5", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo356 = new LatentStyleExceptionInfo() { Name = "List Table 2 Accent 5", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo357 = new LatentStyleExceptionInfo() { Name = "List Table 3 Accent 5", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo358 = new LatentStyleExceptionInfo() { Name = "List Table 4 Accent 5", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo359 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark Accent 5", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo360 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful Accent 5", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo361 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful Accent 5", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo362 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light Accent 6", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo363 = new LatentStyleExceptionInfo() { Name = "List Table 2 Accent 6", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo364 = new LatentStyleExceptionInfo() { Name = "List Table 3 Accent 6", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo365 = new LatentStyleExceptionInfo() { Name = "List Table 4 Accent 6", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo366 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark Accent 6", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo367 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful Accent 6", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo368 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful Accent 6", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo369 = new LatentStyleExceptionInfo() { Name = "Mention", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo370 = new LatentStyleExceptionInfo() { Name = "Smart Hyperlink", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo371 = new LatentStyleExceptionInfo() { Name = "Hashtag", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo372 = new LatentStyleExceptionInfo() { Name = "Unresolved Mention", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo373 = new LatentStyleExceptionInfo() { Name = "Smart Link", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo374 = new LatentStyleExceptionInfo() { Name = "Smart Link Error", SemiHidden = true, UnhideWhenUsed = true };

            latentStyles1.Append(latentStyleExceptionInfo1);
            latentStyles1.Append(latentStyleExceptionInfo2);
            latentStyles1.Append(latentStyleExceptionInfo3);
            latentStyles1.Append(latentStyleExceptionInfo4);
            latentStyles1.Append(latentStyleExceptionInfo5);
            latentStyles1.Append(latentStyleExceptionInfo6);
            latentStyles1.Append(latentStyleExceptionInfo7);
            latentStyles1.Append(latentStyleExceptionInfo8);
            latentStyles1.Append(latentStyleExceptionInfo9);
            latentStyles1.Append(latentStyleExceptionInfo10);
            latentStyles1.Append(latentStyleExceptionInfo11);
            latentStyles1.Append(latentStyleExceptionInfo12);
            latentStyles1.Append(latentStyleExceptionInfo13);
            latentStyles1.Append(latentStyleExceptionInfo14);
            latentStyles1.Append(latentStyleExceptionInfo15);
            latentStyles1.Append(latentStyleExceptionInfo16);
            latentStyles1.Append(latentStyleExceptionInfo17);
            latentStyles1.Append(latentStyleExceptionInfo18);
            latentStyles1.Append(latentStyleExceptionInfo19);
            latentStyles1.Append(latentStyleExceptionInfo20);
            latentStyles1.Append(latentStyleExceptionInfo21);
            latentStyles1.Append(latentStyleExceptionInfo22);
            latentStyles1.Append(latentStyleExceptionInfo23);
            latentStyles1.Append(latentStyleExceptionInfo24);
            latentStyles1.Append(latentStyleExceptionInfo25);
            latentStyles1.Append(latentStyleExceptionInfo26);
            latentStyles1.Append(latentStyleExceptionInfo27);
            latentStyles1.Append(latentStyleExceptionInfo28);
            latentStyles1.Append(latentStyleExceptionInfo29);
            latentStyles1.Append(latentStyleExceptionInfo30);
            latentStyles1.Append(latentStyleExceptionInfo31);
            latentStyles1.Append(latentStyleExceptionInfo32);
            latentStyles1.Append(latentStyleExceptionInfo33);
            latentStyles1.Append(latentStyleExceptionInfo34);
            latentStyles1.Append(latentStyleExceptionInfo35);
            latentStyles1.Append(latentStyleExceptionInfo36);
            latentStyles1.Append(latentStyleExceptionInfo37);
            latentStyles1.Append(latentStyleExceptionInfo38);
            latentStyles1.Append(latentStyleExceptionInfo39);
            latentStyles1.Append(latentStyleExceptionInfo40);
            latentStyles1.Append(latentStyleExceptionInfo41);
            latentStyles1.Append(latentStyleExceptionInfo42);
            latentStyles1.Append(latentStyleExceptionInfo43);
            latentStyles1.Append(latentStyleExceptionInfo44);
            latentStyles1.Append(latentStyleExceptionInfo45);
            latentStyles1.Append(latentStyleExceptionInfo46);
            latentStyles1.Append(latentStyleExceptionInfo47);
            latentStyles1.Append(latentStyleExceptionInfo48);
            latentStyles1.Append(latentStyleExceptionInfo49);
            latentStyles1.Append(latentStyleExceptionInfo50);
            latentStyles1.Append(latentStyleExceptionInfo51);
            latentStyles1.Append(latentStyleExceptionInfo52);
            latentStyles1.Append(latentStyleExceptionInfo53);
            latentStyles1.Append(latentStyleExceptionInfo54);
            latentStyles1.Append(latentStyleExceptionInfo55);
            latentStyles1.Append(latentStyleExceptionInfo56);
            latentStyles1.Append(latentStyleExceptionInfo57);
            latentStyles1.Append(latentStyleExceptionInfo58);
            latentStyles1.Append(latentStyleExceptionInfo59);
            latentStyles1.Append(latentStyleExceptionInfo60);
            latentStyles1.Append(latentStyleExceptionInfo61);
            latentStyles1.Append(latentStyleExceptionInfo62);
            latentStyles1.Append(latentStyleExceptionInfo63);
            latentStyles1.Append(latentStyleExceptionInfo64);
            latentStyles1.Append(latentStyleExceptionInfo65);
            latentStyles1.Append(latentStyleExceptionInfo66);
            latentStyles1.Append(latentStyleExceptionInfo67);
            latentStyles1.Append(latentStyleExceptionInfo68);
            latentStyles1.Append(latentStyleExceptionInfo69);
            latentStyles1.Append(latentStyleExceptionInfo70);
            latentStyles1.Append(latentStyleExceptionInfo71);
            latentStyles1.Append(latentStyleExceptionInfo72);
            latentStyles1.Append(latentStyleExceptionInfo73);
            latentStyles1.Append(latentStyleExceptionInfo74);
            latentStyles1.Append(latentStyleExceptionInfo75);
            latentStyles1.Append(latentStyleExceptionInfo76);
            latentStyles1.Append(latentStyleExceptionInfo77);
            latentStyles1.Append(latentStyleExceptionInfo78);
            latentStyles1.Append(latentStyleExceptionInfo79);
            latentStyles1.Append(latentStyleExceptionInfo80);
            latentStyles1.Append(latentStyleExceptionInfo81);
            latentStyles1.Append(latentStyleExceptionInfo82);
            latentStyles1.Append(latentStyleExceptionInfo83);
            latentStyles1.Append(latentStyleExceptionInfo84);
            latentStyles1.Append(latentStyleExceptionInfo85);
            latentStyles1.Append(latentStyleExceptionInfo86);
            latentStyles1.Append(latentStyleExceptionInfo87);
            latentStyles1.Append(latentStyleExceptionInfo88);
            latentStyles1.Append(latentStyleExceptionInfo89);
            latentStyles1.Append(latentStyleExceptionInfo90);
            latentStyles1.Append(latentStyleExceptionInfo91);
            latentStyles1.Append(latentStyleExceptionInfo92);
            latentStyles1.Append(latentStyleExceptionInfo93);
            latentStyles1.Append(latentStyleExceptionInfo94);
            latentStyles1.Append(latentStyleExceptionInfo95);
            latentStyles1.Append(latentStyleExceptionInfo96);
            latentStyles1.Append(latentStyleExceptionInfo97);
            latentStyles1.Append(latentStyleExceptionInfo98);
            latentStyles1.Append(latentStyleExceptionInfo99);
            latentStyles1.Append(latentStyleExceptionInfo100);
            latentStyles1.Append(latentStyleExceptionInfo101);
            latentStyles1.Append(latentStyleExceptionInfo102);
            latentStyles1.Append(latentStyleExceptionInfo103);
            latentStyles1.Append(latentStyleExceptionInfo104);
            latentStyles1.Append(latentStyleExceptionInfo105);
            latentStyles1.Append(latentStyleExceptionInfo106);
            latentStyles1.Append(latentStyleExceptionInfo107);
            latentStyles1.Append(latentStyleExceptionInfo108);
            latentStyles1.Append(latentStyleExceptionInfo109);
            latentStyles1.Append(latentStyleExceptionInfo110);
            latentStyles1.Append(latentStyleExceptionInfo111);
            latentStyles1.Append(latentStyleExceptionInfo112);
            latentStyles1.Append(latentStyleExceptionInfo113);
            latentStyles1.Append(latentStyleExceptionInfo114);
            latentStyles1.Append(latentStyleExceptionInfo115);
            latentStyles1.Append(latentStyleExceptionInfo116);
            latentStyles1.Append(latentStyleExceptionInfo117);
            latentStyles1.Append(latentStyleExceptionInfo118);
            latentStyles1.Append(latentStyleExceptionInfo119);
            latentStyles1.Append(latentStyleExceptionInfo120);
            latentStyles1.Append(latentStyleExceptionInfo121);
            latentStyles1.Append(latentStyleExceptionInfo122);
            latentStyles1.Append(latentStyleExceptionInfo123);
            latentStyles1.Append(latentStyleExceptionInfo124);
            latentStyles1.Append(latentStyleExceptionInfo125);
            latentStyles1.Append(latentStyleExceptionInfo126);
            latentStyles1.Append(latentStyleExceptionInfo127);
            latentStyles1.Append(latentStyleExceptionInfo128);
            latentStyles1.Append(latentStyleExceptionInfo129);
            latentStyles1.Append(latentStyleExceptionInfo130);
            latentStyles1.Append(latentStyleExceptionInfo131);
            latentStyles1.Append(latentStyleExceptionInfo132);
            latentStyles1.Append(latentStyleExceptionInfo133);
            latentStyles1.Append(latentStyleExceptionInfo134);
            latentStyles1.Append(latentStyleExceptionInfo135);
            latentStyles1.Append(latentStyleExceptionInfo136);
            latentStyles1.Append(latentStyleExceptionInfo137);
            latentStyles1.Append(latentStyleExceptionInfo138);
            latentStyles1.Append(latentStyleExceptionInfo139);
            latentStyles1.Append(latentStyleExceptionInfo140);
            latentStyles1.Append(latentStyleExceptionInfo141);
            latentStyles1.Append(latentStyleExceptionInfo142);
            latentStyles1.Append(latentStyleExceptionInfo143);
            latentStyles1.Append(latentStyleExceptionInfo144);
            latentStyles1.Append(latentStyleExceptionInfo145);
            latentStyles1.Append(latentStyleExceptionInfo146);
            latentStyles1.Append(latentStyleExceptionInfo147);
            latentStyles1.Append(latentStyleExceptionInfo148);
            latentStyles1.Append(latentStyleExceptionInfo149);
            latentStyles1.Append(latentStyleExceptionInfo150);
            latentStyles1.Append(latentStyleExceptionInfo151);
            latentStyles1.Append(latentStyleExceptionInfo152);
            latentStyles1.Append(latentStyleExceptionInfo153);
            latentStyles1.Append(latentStyleExceptionInfo154);
            latentStyles1.Append(latentStyleExceptionInfo155);
            latentStyles1.Append(latentStyleExceptionInfo156);
            latentStyles1.Append(latentStyleExceptionInfo157);
            latentStyles1.Append(latentStyleExceptionInfo158);
            latentStyles1.Append(latentStyleExceptionInfo159);
            latentStyles1.Append(latentStyleExceptionInfo160);
            latentStyles1.Append(latentStyleExceptionInfo161);
            latentStyles1.Append(latentStyleExceptionInfo162);
            latentStyles1.Append(latentStyleExceptionInfo163);
            latentStyles1.Append(latentStyleExceptionInfo164);
            latentStyles1.Append(latentStyleExceptionInfo165);
            latentStyles1.Append(latentStyleExceptionInfo166);
            latentStyles1.Append(latentStyleExceptionInfo167);
            latentStyles1.Append(latentStyleExceptionInfo168);
            latentStyles1.Append(latentStyleExceptionInfo169);
            latentStyles1.Append(latentStyleExceptionInfo170);
            latentStyles1.Append(latentStyleExceptionInfo171);
            latentStyles1.Append(latentStyleExceptionInfo172);
            latentStyles1.Append(latentStyleExceptionInfo173);
            latentStyles1.Append(latentStyleExceptionInfo174);
            latentStyles1.Append(latentStyleExceptionInfo175);
            latentStyles1.Append(latentStyleExceptionInfo176);
            latentStyles1.Append(latentStyleExceptionInfo177);
            latentStyles1.Append(latentStyleExceptionInfo178);
            latentStyles1.Append(latentStyleExceptionInfo179);
            latentStyles1.Append(latentStyleExceptionInfo180);
            latentStyles1.Append(latentStyleExceptionInfo181);
            latentStyles1.Append(latentStyleExceptionInfo182);
            latentStyles1.Append(latentStyleExceptionInfo183);
            latentStyles1.Append(latentStyleExceptionInfo184);
            latentStyles1.Append(latentStyleExceptionInfo185);
            latentStyles1.Append(latentStyleExceptionInfo186);
            latentStyles1.Append(latentStyleExceptionInfo187);
            latentStyles1.Append(latentStyleExceptionInfo188);
            latentStyles1.Append(latentStyleExceptionInfo189);
            latentStyles1.Append(latentStyleExceptionInfo190);
            latentStyles1.Append(latentStyleExceptionInfo191);
            latentStyles1.Append(latentStyleExceptionInfo192);
            latentStyles1.Append(latentStyleExceptionInfo193);
            latentStyles1.Append(latentStyleExceptionInfo194);
            latentStyles1.Append(latentStyleExceptionInfo195);
            latentStyles1.Append(latentStyleExceptionInfo196);
            latentStyles1.Append(latentStyleExceptionInfo197);
            latentStyles1.Append(latentStyleExceptionInfo198);
            latentStyles1.Append(latentStyleExceptionInfo199);
            latentStyles1.Append(latentStyleExceptionInfo200);
            latentStyles1.Append(latentStyleExceptionInfo201);
            latentStyles1.Append(latentStyleExceptionInfo202);
            latentStyles1.Append(latentStyleExceptionInfo203);
            latentStyles1.Append(latentStyleExceptionInfo204);
            latentStyles1.Append(latentStyleExceptionInfo205);
            latentStyles1.Append(latentStyleExceptionInfo206);
            latentStyles1.Append(latentStyleExceptionInfo207);
            latentStyles1.Append(latentStyleExceptionInfo208);
            latentStyles1.Append(latentStyleExceptionInfo209);
            latentStyles1.Append(latentStyleExceptionInfo210);
            latentStyles1.Append(latentStyleExceptionInfo211);
            latentStyles1.Append(latentStyleExceptionInfo212);
            latentStyles1.Append(latentStyleExceptionInfo213);
            latentStyles1.Append(latentStyleExceptionInfo214);
            latentStyles1.Append(latentStyleExceptionInfo215);
            latentStyles1.Append(latentStyleExceptionInfo216);
            latentStyles1.Append(latentStyleExceptionInfo217);
            latentStyles1.Append(latentStyleExceptionInfo218);
            latentStyles1.Append(latentStyleExceptionInfo219);
            latentStyles1.Append(latentStyleExceptionInfo220);
            latentStyles1.Append(latentStyleExceptionInfo221);
            latentStyles1.Append(latentStyleExceptionInfo222);
            latentStyles1.Append(latentStyleExceptionInfo223);
            latentStyles1.Append(latentStyleExceptionInfo224);
            latentStyles1.Append(latentStyleExceptionInfo225);
            latentStyles1.Append(latentStyleExceptionInfo226);
            latentStyles1.Append(latentStyleExceptionInfo227);
            latentStyles1.Append(latentStyleExceptionInfo228);
            latentStyles1.Append(latentStyleExceptionInfo229);
            latentStyles1.Append(latentStyleExceptionInfo230);
            latentStyles1.Append(latentStyleExceptionInfo231);
            latentStyles1.Append(latentStyleExceptionInfo232);
            latentStyles1.Append(latentStyleExceptionInfo233);
            latentStyles1.Append(latentStyleExceptionInfo234);
            latentStyles1.Append(latentStyleExceptionInfo235);
            latentStyles1.Append(latentStyleExceptionInfo236);
            latentStyles1.Append(latentStyleExceptionInfo237);
            latentStyles1.Append(latentStyleExceptionInfo238);
            latentStyles1.Append(latentStyleExceptionInfo239);
            latentStyles1.Append(latentStyleExceptionInfo240);
            latentStyles1.Append(latentStyleExceptionInfo241);
            latentStyles1.Append(latentStyleExceptionInfo242);
            latentStyles1.Append(latentStyleExceptionInfo243);
            latentStyles1.Append(latentStyleExceptionInfo244);
            latentStyles1.Append(latentStyleExceptionInfo245);
            latentStyles1.Append(latentStyleExceptionInfo246);
            latentStyles1.Append(latentStyleExceptionInfo247);
            latentStyles1.Append(latentStyleExceptionInfo248);
            latentStyles1.Append(latentStyleExceptionInfo249);
            latentStyles1.Append(latentStyleExceptionInfo250);
            latentStyles1.Append(latentStyleExceptionInfo251);
            latentStyles1.Append(latentStyleExceptionInfo252);
            latentStyles1.Append(latentStyleExceptionInfo253);
            latentStyles1.Append(latentStyleExceptionInfo254);
            latentStyles1.Append(latentStyleExceptionInfo255);
            latentStyles1.Append(latentStyleExceptionInfo256);
            latentStyles1.Append(latentStyleExceptionInfo257);
            latentStyles1.Append(latentStyleExceptionInfo258);
            latentStyles1.Append(latentStyleExceptionInfo259);
            latentStyles1.Append(latentStyleExceptionInfo260);
            latentStyles1.Append(latentStyleExceptionInfo261);
            latentStyles1.Append(latentStyleExceptionInfo262);
            latentStyles1.Append(latentStyleExceptionInfo263);
            latentStyles1.Append(latentStyleExceptionInfo264);
            latentStyles1.Append(latentStyleExceptionInfo265);
            latentStyles1.Append(latentStyleExceptionInfo266);
            latentStyles1.Append(latentStyleExceptionInfo267);
            latentStyles1.Append(latentStyleExceptionInfo268);
            latentStyles1.Append(latentStyleExceptionInfo269);
            latentStyles1.Append(latentStyleExceptionInfo270);
            latentStyles1.Append(latentStyleExceptionInfo271);
            latentStyles1.Append(latentStyleExceptionInfo272);
            latentStyles1.Append(latentStyleExceptionInfo273);
            latentStyles1.Append(latentStyleExceptionInfo274);
            latentStyles1.Append(latentStyleExceptionInfo275);
            latentStyles1.Append(latentStyleExceptionInfo276);
            latentStyles1.Append(latentStyleExceptionInfo277);
            latentStyles1.Append(latentStyleExceptionInfo278);
            latentStyles1.Append(latentStyleExceptionInfo279);
            latentStyles1.Append(latentStyleExceptionInfo280);
            latentStyles1.Append(latentStyleExceptionInfo281);
            latentStyles1.Append(latentStyleExceptionInfo282);
            latentStyles1.Append(latentStyleExceptionInfo283);
            latentStyles1.Append(latentStyleExceptionInfo284);
            latentStyles1.Append(latentStyleExceptionInfo285);
            latentStyles1.Append(latentStyleExceptionInfo286);
            latentStyles1.Append(latentStyleExceptionInfo287);
            latentStyles1.Append(latentStyleExceptionInfo288);
            latentStyles1.Append(latentStyleExceptionInfo289);
            latentStyles1.Append(latentStyleExceptionInfo290);
            latentStyles1.Append(latentStyleExceptionInfo291);
            latentStyles1.Append(latentStyleExceptionInfo292);
            latentStyles1.Append(latentStyleExceptionInfo293);
            latentStyles1.Append(latentStyleExceptionInfo294);
            latentStyles1.Append(latentStyleExceptionInfo295);
            latentStyles1.Append(latentStyleExceptionInfo296);
            latentStyles1.Append(latentStyleExceptionInfo297);
            latentStyles1.Append(latentStyleExceptionInfo298);
            latentStyles1.Append(latentStyleExceptionInfo299);
            latentStyles1.Append(latentStyleExceptionInfo300);
            latentStyles1.Append(latentStyleExceptionInfo301);
            latentStyles1.Append(latentStyleExceptionInfo302);
            latentStyles1.Append(latentStyleExceptionInfo303);
            latentStyles1.Append(latentStyleExceptionInfo304);
            latentStyles1.Append(latentStyleExceptionInfo305);
            latentStyles1.Append(latentStyleExceptionInfo306);
            latentStyles1.Append(latentStyleExceptionInfo307);
            latentStyles1.Append(latentStyleExceptionInfo308);
            latentStyles1.Append(latentStyleExceptionInfo309);
            latentStyles1.Append(latentStyleExceptionInfo310);
            latentStyles1.Append(latentStyleExceptionInfo311);
            latentStyles1.Append(latentStyleExceptionInfo312);
            latentStyles1.Append(latentStyleExceptionInfo313);
            latentStyles1.Append(latentStyleExceptionInfo314);
            latentStyles1.Append(latentStyleExceptionInfo315);
            latentStyles1.Append(latentStyleExceptionInfo316);
            latentStyles1.Append(latentStyleExceptionInfo317);
            latentStyles1.Append(latentStyleExceptionInfo318);
            latentStyles1.Append(latentStyleExceptionInfo319);
            latentStyles1.Append(latentStyleExceptionInfo320);
            latentStyles1.Append(latentStyleExceptionInfo321);
            latentStyles1.Append(latentStyleExceptionInfo322);
            latentStyles1.Append(latentStyleExceptionInfo323);
            latentStyles1.Append(latentStyleExceptionInfo324);
            latentStyles1.Append(latentStyleExceptionInfo325);
            latentStyles1.Append(latentStyleExceptionInfo326);
            latentStyles1.Append(latentStyleExceptionInfo327);
            latentStyles1.Append(latentStyleExceptionInfo328);
            latentStyles1.Append(latentStyleExceptionInfo329);
            latentStyles1.Append(latentStyleExceptionInfo330);
            latentStyles1.Append(latentStyleExceptionInfo331);
            latentStyles1.Append(latentStyleExceptionInfo332);
            latentStyles1.Append(latentStyleExceptionInfo333);
            latentStyles1.Append(latentStyleExceptionInfo334);
            latentStyles1.Append(latentStyleExceptionInfo335);
            latentStyles1.Append(latentStyleExceptionInfo336);
            latentStyles1.Append(latentStyleExceptionInfo337);
            latentStyles1.Append(latentStyleExceptionInfo338);
            latentStyles1.Append(latentStyleExceptionInfo339);
            latentStyles1.Append(latentStyleExceptionInfo340);
            latentStyles1.Append(latentStyleExceptionInfo341);
            latentStyles1.Append(latentStyleExceptionInfo342);
            latentStyles1.Append(latentStyleExceptionInfo343);
            latentStyles1.Append(latentStyleExceptionInfo344);
            latentStyles1.Append(latentStyleExceptionInfo345);
            latentStyles1.Append(latentStyleExceptionInfo346);
            latentStyles1.Append(latentStyleExceptionInfo347);
            latentStyles1.Append(latentStyleExceptionInfo348);
            latentStyles1.Append(latentStyleExceptionInfo349);
            latentStyles1.Append(latentStyleExceptionInfo350);
            latentStyles1.Append(latentStyleExceptionInfo351);
            latentStyles1.Append(latentStyleExceptionInfo352);
            latentStyles1.Append(latentStyleExceptionInfo353);
            latentStyles1.Append(latentStyleExceptionInfo354);
            latentStyles1.Append(latentStyleExceptionInfo355);
            latentStyles1.Append(latentStyleExceptionInfo356);
            latentStyles1.Append(latentStyleExceptionInfo357);
            latentStyles1.Append(latentStyleExceptionInfo358);
            latentStyles1.Append(latentStyleExceptionInfo359);
            latentStyles1.Append(latentStyleExceptionInfo360);
            latentStyles1.Append(latentStyleExceptionInfo361);
            latentStyles1.Append(latentStyleExceptionInfo362);
            latentStyles1.Append(latentStyleExceptionInfo363);
            latentStyles1.Append(latentStyleExceptionInfo364);
            latentStyles1.Append(latentStyleExceptionInfo365);
            latentStyles1.Append(latentStyleExceptionInfo366);
            latentStyles1.Append(latentStyleExceptionInfo367);
            latentStyles1.Append(latentStyleExceptionInfo368);
            latentStyles1.Append(latentStyleExceptionInfo369);
            latentStyles1.Append(latentStyleExceptionInfo370);
            latentStyles1.Append(latentStyleExceptionInfo371);
            latentStyles1.Append(latentStyleExceptionInfo372);
            latentStyles1.Append(latentStyleExceptionInfo373);
            latentStyles1.Append(latentStyleExceptionInfo374);

            Style style1 = new Style() { Type = StyleValues.Paragraph, StyleId = "a", Default = true };
            StyleName styleName1 = new StyleName() { Val = "Normal" };
            PrimaryStyle primaryStyle1 = new PrimaryStyle();

            style1.Append(styleName1);
            style1.Append(primaryStyle1);

            Style style2 = new Style() { Type = StyleValues.Character, StyleId = "a0", Default = true };
            StyleName styleName2 = new StyleName() { Val = "Default Paragraph Font" };
            UIPriority uIPriority1 = new UIPriority() { Val = 1 };
            SemiHidden semiHidden1 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed1 = new UnhideWhenUsed();

            style2.Append(styleName2);
            style2.Append(uIPriority1);
            style2.Append(semiHidden1);
            style2.Append(unhideWhenUsed1);

            Style style3 = new Style() { Type = StyleValues.Table, StyleId = "a1", Default = true };
            StyleName styleName3 = new StyleName() { Val = "Normal Table" };
            UIPriority uIPriority2 = new UIPriority() { Val = 99 };
            SemiHidden semiHidden2 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed2 = new UnhideWhenUsed();

            StyleTableProperties styleTableProperties1 = new StyleTableProperties();
            TableIndentation tableIndentation1 = new TableIndentation() { Width = 0, Type = TableWidthUnitValues.Dxa };

            TableCellMarginDefault tableCellMarginDefault1 = new TableCellMarginDefault();
            TopMargin topMargin1 = new TopMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellLeftMargin tableCellLeftMargin1 = new TableCellLeftMargin() { Width = 108, Type = TableWidthValues.Dxa };
            BottomMargin bottomMargin1 = new BottomMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellRightMargin tableCellRightMargin1 = new TableCellRightMargin() { Width = 108, Type = TableWidthValues.Dxa };

            tableCellMarginDefault1.Append(topMargin1);
            tableCellMarginDefault1.Append(tableCellLeftMargin1);
            tableCellMarginDefault1.Append(bottomMargin1);
            tableCellMarginDefault1.Append(tableCellRightMargin1);

            styleTableProperties1.Append(tableIndentation1);
            styleTableProperties1.Append(tableCellMarginDefault1);

            style3.Append(styleName3);
            style3.Append(uIPriority2);
            style3.Append(semiHidden2);
            style3.Append(unhideWhenUsed2);
            style3.Append(styleTableProperties1);

            Style style4 = new Style() { Type = StyleValues.Numbering, StyleId = "a2", Default = true };
            StyleName styleName4 = new StyleName() { Val = "No List" };
            UIPriority uIPriority3 = new UIPriority() { Val = 99 };
            SemiHidden semiHidden3 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed3 = new UnhideWhenUsed();

            style4.Append(styleName4);
            style4.Append(uIPriority3);
            style4.Append(semiHidden3);
            style4.Append(unhideWhenUsed3);

            Style style5 = new Style() { Type = StyleValues.Paragraph, StyleId = "a3" };
            StyleName styleName5 = new StyleName() { Val = "Title" };
            BasedOn basedOn1 = new BasedOn() { Val = "a" };
            NextParagraphStyle nextParagraphStyle1 = new NextParagraphStyle() { Val = "a" };
            LinkedStyle linkedStyle1 = new LinkedStyle() { Val = "a4" };
            UIPriority uIPriority4 = new UIPriority() { Val = 10 };
            PrimaryStyle primaryStyle2 = new PrimaryStyle();
            Rsid rsid4 = new Rsid() { Val = "00827FBB" };

            StyleParagraphProperties styleParagraphProperties1 = new StyleParagraphProperties();
            SpacingBetweenLines spacingBetweenLines2 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            ContextualSpacing contextualSpacing1 = new ContextualSpacing();

            styleParagraphProperties1.Append(spacingBetweenLines2);
            styleParagraphProperties1.Append(contextualSpacing1);

            StyleRunProperties styleRunProperties1 = new StyleRunProperties();
            RunFonts runFonts2 = new RunFonts() { AsciiTheme = ThemeFontValues.MajorHighAnsi, HighAnsiTheme = ThemeFontValues.MajorHighAnsi, EastAsiaTheme = ThemeFontValues.MajorEastAsia, ComplexScriptTheme = ThemeFontValues.MajorBidi };
            Spacing spacing2 = new Spacing() { Val = -10 };
            Kern kern1 = new Kern() { Val = (UInt32Value)28U };
            FontSize fontSize21 = new FontSize() { Val = "56" };
            FontSizeComplexScript fontSizeComplexScript21 = new FontSizeComplexScript() { Val = "56" };

            styleRunProperties1.Append(runFonts2);
            styleRunProperties1.Append(spacing2);
            styleRunProperties1.Append(kern1);
            styleRunProperties1.Append(fontSize21);
            styleRunProperties1.Append(fontSizeComplexScript21);

            style5.Append(styleName5);
            style5.Append(basedOn1);
            style5.Append(nextParagraphStyle1);
            style5.Append(linkedStyle1);
            style5.Append(uIPriority4);
            style5.Append(primaryStyle2);
            style5.Append(rsid4);
            style5.Append(styleParagraphProperties1);
            style5.Append(styleRunProperties1);

            Style style6 = new Style() { Type = StyleValues.Character, StyleId = "a4", CustomStyle = true };
            StyleName styleName6 = new StyleName() { Val = "Заголовок Знак" };
            BasedOn basedOn2 = new BasedOn() { Val = "a0" };
            LinkedStyle linkedStyle2 = new LinkedStyle() { Val = "a3" };
            UIPriority uIPriority5 = new UIPriority() { Val = 10 };
            Rsid rsid5 = new Rsid() { Val = "00827FBB" };

            StyleRunProperties styleRunProperties2 = new StyleRunProperties();
            RunFonts runFonts3 = new RunFonts() { AsciiTheme = ThemeFontValues.MajorHighAnsi, HighAnsiTheme = ThemeFontValues.MajorHighAnsi, EastAsiaTheme = ThemeFontValues.MajorEastAsia, ComplexScriptTheme = ThemeFontValues.MajorBidi };
            Spacing spacing3 = new Spacing() { Val = -10 };
            Kern kern2 = new Kern() { Val = (UInt32Value)28U };
            FontSize fontSize22 = new FontSize() { Val = "56" };
            FontSizeComplexScript fontSizeComplexScript22 = new FontSizeComplexScript() { Val = "56" };

            styleRunProperties2.Append(runFonts3);
            styleRunProperties2.Append(spacing3);
            styleRunProperties2.Append(kern2);
            styleRunProperties2.Append(fontSize22);
            styleRunProperties2.Append(fontSizeComplexScript22);

            style6.Append(styleName6);
            style6.Append(basedOn2);
            style6.Append(linkedStyle2);
            style6.Append(uIPriority5);
            style6.Append(rsid5);
            style6.Append(styleRunProperties2);

            Style style7 = new Style() { Type = StyleValues.Table, StyleId = "a5" };
            StyleName styleName7 = new StyleName() { Val = "Table Grid" };
            BasedOn basedOn3 = new BasedOn() { Val = "a1" };
            UIPriority uIPriority6 = new UIPriority() { Val = 39 };
            Rsid rsid6 = new Rsid() { Val = "00827FBB" };

            StyleParagraphProperties styleParagraphProperties2 = new StyleParagraphProperties();
            SpacingBetweenLines spacingBetweenLines3 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            styleParagraphProperties2.Append(spacingBetweenLines3);

            StyleTableProperties styleTableProperties2 = new StyleTableProperties();

            TableBorders tableBorders1 = new TableBorders();
            TopBorder topBorder1 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder1 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder1 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder1 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideHorizontalBorder insideHorizontalBorder1 = new InsideHorizontalBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideVerticalBorder insideVerticalBorder1 = new InsideVerticalBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableBorders1.Append(topBorder1);
            tableBorders1.Append(leftBorder1);
            tableBorders1.Append(bottomBorder1);
            tableBorders1.Append(rightBorder1);
            tableBorders1.Append(insideHorizontalBorder1);
            tableBorders1.Append(insideVerticalBorder1);

            styleTableProperties2.Append(tableBorders1);

            style7.Append(styleName7);
            style7.Append(basedOn3);
            style7.Append(uIPriority6);
            style7.Append(rsid6);
            style7.Append(styleParagraphProperties2);
            style7.Append(styleTableProperties2);

            styles1.Append(docDefaults1);
            styles1.Append(latentStyles1);
            styles1.Append(style1);
            styles1.Append(style2);
            styles1.Append(style3);
            styles1.Append(style4);
            styles1.Append(style5);
            styles1.Append(style6);
            styles1.Append(style7);

            styleDefinitionsPart1.Styles = styles1;
        }

        // Generates content of themePart1.
        private void GenerateThemePart1Content(ThemePart themePart1)
        {
            A.Theme theme1 = new A.Theme() { Name = "Office Theme" };
            theme1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.ThemeElements themeElements1 = new A.ThemeElements();

            A.ColorScheme colorScheme1 = new A.ColorScheme() { Name = "Office" };

            A.Dark1Color dark1Color1 = new A.Dark1Color();
            A.SystemColor systemColor1 = new A.SystemColor() { Val = A.SystemColorValues.WindowText, LastColor = "000000" };

            dark1Color1.Append(systemColor1);

            A.Light1Color light1Color1 = new A.Light1Color();
            A.SystemColor systemColor2 = new A.SystemColor() { Val = A.SystemColorValues.Window, LastColor = "FFFFFF" };

            light1Color1.Append(systemColor2);

            A.Dark2Color dark2Color1 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex34 = new A.RgbColorModelHex() { Val = "44546A" };

            dark2Color1.Append(rgbColorModelHex34);

            A.Light2Color light2Color1 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex35 = new A.RgbColorModelHex() { Val = "E7E6E6" };

            light2Color1.Append(rgbColorModelHex35);

            A.Accent1Color accent1Color1 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex36 = new A.RgbColorModelHex() { Val = "4472C4" };

            accent1Color1.Append(rgbColorModelHex36);

            A.Accent2Color accent2Color1 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex37 = new A.RgbColorModelHex() { Val = "ED7D31" };

            accent2Color1.Append(rgbColorModelHex37);

            A.Accent3Color accent3Color1 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex38 = new A.RgbColorModelHex() { Val = "A5A5A5" };

            accent3Color1.Append(rgbColorModelHex38);

            A.Accent4Color accent4Color1 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex39 = new A.RgbColorModelHex() { Val = "FFC000" };

            accent4Color1.Append(rgbColorModelHex39);

            A.Accent5Color accent5Color1 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex40 = new A.RgbColorModelHex() { Val = "5B9BD5" };

            accent5Color1.Append(rgbColorModelHex40);

            A.Accent6Color accent6Color1 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex41 = new A.RgbColorModelHex() { Val = "70AD47" };

            accent6Color1.Append(rgbColorModelHex41);

            A.Hyperlink hyperlink1 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex42 = new A.RgbColorModelHex() { Val = "0563C1" };

            hyperlink1.Append(rgbColorModelHex42);

            A.FollowedHyperlinkColor followedHyperlinkColor1 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex43 = new A.RgbColorModelHex() { Val = "954F72" };

            followedHyperlinkColor1.Append(rgbColorModelHex43);

            colorScheme1.Append(dark1Color1);
            colorScheme1.Append(light1Color1);
            colorScheme1.Append(dark2Color1);
            colorScheme1.Append(light2Color1);
            colorScheme1.Append(accent1Color1);
            colorScheme1.Append(accent2Color1);
            colorScheme1.Append(accent3Color1);
            colorScheme1.Append(accent4Color1);
            colorScheme1.Append(accent5Color1);
            colorScheme1.Append(accent6Color1);
            colorScheme1.Append(hyperlink1);
            colorScheme1.Append(followedHyperlinkColor1);

            A.FontScheme fontScheme1 = new A.FontScheme() { Name = "Office" };

            A.MajorFont majorFont1 = new A.MajorFont();
            A.LatinFont latinFont1 = new A.LatinFont() { Typeface = "Calibri Light", Panose = "020F0302020204030204" };
            A.EastAsianFont eastAsianFont1 = new A.EastAsianFont() { Typeface = "" };
            A.ComplexScriptFont complexScriptFont1 = new A.ComplexScriptFont() { Typeface = "" };
            A.SupplementalFont supplementalFont1 = new A.SupplementalFont() { Script = "Jpan", Typeface = "游ゴシック Light" };
            A.SupplementalFont supplementalFont2 = new A.SupplementalFont() { Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont3 = new A.SupplementalFont() { Script = "Hans", Typeface = "等线 Light" };
            A.SupplementalFont supplementalFont4 = new A.SupplementalFont() { Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont5 = new A.SupplementalFont() { Script = "Arab", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont6 = new A.SupplementalFont() { Script = "Hebr", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont7 = new A.SupplementalFont() { Script = "Thai", Typeface = "Angsana New" };
            A.SupplementalFont supplementalFont8 = new A.SupplementalFont() { Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont9 = new A.SupplementalFont() { Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont10 = new A.SupplementalFont() { Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont11 = new A.SupplementalFont() { Script = "Khmr", Typeface = "MoolBoran" };
            A.SupplementalFont supplementalFont12 = new A.SupplementalFont() { Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont13 = new A.SupplementalFont() { Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont14 = new A.SupplementalFont() { Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont15 = new A.SupplementalFont() { Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont16 = new A.SupplementalFont() { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont17 = new A.SupplementalFont() { Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont18 = new A.SupplementalFont() { Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont19 = new A.SupplementalFont() { Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont20 = new A.SupplementalFont() { Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont21 = new A.SupplementalFont() { Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont22 = new A.SupplementalFont() { Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont23 = new A.SupplementalFont() { Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont24 = new A.SupplementalFont() { Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont25 = new A.SupplementalFont() { Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont26 = new A.SupplementalFont() { Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont27 = new A.SupplementalFont() { Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont28 = new A.SupplementalFont() { Script = "Viet", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont29 = new A.SupplementalFont() { Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont30 = new A.SupplementalFont() { Script = "Geor", Typeface = "Sylfaen" };
            A.SupplementalFont supplementalFont31 = new A.SupplementalFont() { Script = "Armn", Typeface = "Arial" };
            A.SupplementalFont supplementalFont32 = new A.SupplementalFont() { Script = "Bugi", Typeface = "Leelawadee UI" };
            A.SupplementalFont supplementalFont33 = new A.SupplementalFont() { Script = "Bopo", Typeface = "Microsoft JhengHei" };
            A.SupplementalFont supplementalFont34 = new A.SupplementalFont() { Script = "Java", Typeface = "Javanese Text" };
            A.SupplementalFont supplementalFont35 = new A.SupplementalFont() { Script = "Lisu", Typeface = "Segoe UI" };
            A.SupplementalFont supplementalFont36 = new A.SupplementalFont() { Script = "Mymr", Typeface = "Myanmar Text" };
            A.SupplementalFont supplementalFont37 = new A.SupplementalFont() { Script = "Nkoo", Typeface = "Ebrima" };
            A.SupplementalFont supplementalFont38 = new A.SupplementalFont() { Script = "Olck", Typeface = "Nirmala UI" };
            A.SupplementalFont supplementalFont39 = new A.SupplementalFont() { Script = "Osma", Typeface = "Ebrima" };
            A.SupplementalFont supplementalFont40 = new A.SupplementalFont() { Script = "Phag", Typeface = "Phagspa" };
            A.SupplementalFont supplementalFont41 = new A.SupplementalFont() { Script = "Syrn", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont42 = new A.SupplementalFont() { Script = "Syrj", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont43 = new A.SupplementalFont() { Script = "Syre", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont44 = new A.SupplementalFont() { Script = "Sora", Typeface = "Nirmala UI" };
            A.SupplementalFont supplementalFont45 = new A.SupplementalFont() { Script = "Tale", Typeface = "Microsoft Tai Le" };
            A.SupplementalFont supplementalFont46 = new A.SupplementalFont() { Script = "Talu", Typeface = "Microsoft New Tai Lue" };
            A.SupplementalFont supplementalFont47 = new A.SupplementalFont() { Script = "Tfng", Typeface = "Ebrima" };

            majorFont1.Append(latinFont1);
            majorFont1.Append(eastAsianFont1);
            majorFont1.Append(complexScriptFont1);
            majorFont1.Append(supplementalFont1);
            majorFont1.Append(supplementalFont2);
            majorFont1.Append(supplementalFont3);
            majorFont1.Append(supplementalFont4);
            majorFont1.Append(supplementalFont5);
            majorFont1.Append(supplementalFont6);
            majorFont1.Append(supplementalFont7);
            majorFont1.Append(supplementalFont8);
            majorFont1.Append(supplementalFont9);
            majorFont1.Append(supplementalFont10);
            majorFont1.Append(supplementalFont11);
            majorFont1.Append(supplementalFont12);
            majorFont1.Append(supplementalFont13);
            majorFont1.Append(supplementalFont14);
            majorFont1.Append(supplementalFont15);
            majorFont1.Append(supplementalFont16);
            majorFont1.Append(supplementalFont17);
            majorFont1.Append(supplementalFont18);
            majorFont1.Append(supplementalFont19);
            majorFont1.Append(supplementalFont20);
            majorFont1.Append(supplementalFont21);
            majorFont1.Append(supplementalFont22);
            majorFont1.Append(supplementalFont23);
            majorFont1.Append(supplementalFont24);
            majorFont1.Append(supplementalFont25);
            majorFont1.Append(supplementalFont26);
            majorFont1.Append(supplementalFont27);
            majorFont1.Append(supplementalFont28);
            majorFont1.Append(supplementalFont29);
            majorFont1.Append(supplementalFont30);
            majorFont1.Append(supplementalFont31);
            majorFont1.Append(supplementalFont32);
            majorFont1.Append(supplementalFont33);
            majorFont1.Append(supplementalFont34);
            majorFont1.Append(supplementalFont35);
            majorFont1.Append(supplementalFont36);
            majorFont1.Append(supplementalFont37);
            majorFont1.Append(supplementalFont38);
            majorFont1.Append(supplementalFont39);
            majorFont1.Append(supplementalFont40);
            majorFont1.Append(supplementalFont41);
            majorFont1.Append(supplementalFont42);
            majorFont1.Append(supplementalFont43);
            majorFont1.Append(supplementalFont44);
            majorFont1.Append(supplementalFont45);
            majorFont1.Append(supplementalFont46);
            majorFont1.Append(supplementalFont47);

            A.MinorFont minorFont1 = new A.MinorFont();
            A.LatinFont latinFont2 = new A.LatinFont() { Typeface = "Calibri", Panose = "020F0502020204030204" };
            A.EastAsianFont eastAsianFont2 = new A.EastAsianFont() { Typeface = "" };
            A.ComplexScriptFont complexScriptFont2 = new A.ComplexScriptFont() { Typeface = "" };
            A.SupplementalFont supplementalFont48 = new A.SupplementalFont() { Script = "Jpan", Typeface = "游明朝" };
            A.SupplementalFont supplementalFont49 = new A.SupplementalFont() { Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont50 = new A.SupplementalFont() { Script = "Hans", Typeface = "等线" };
            A.SupplementalFont supplementalFont51 = new A.SupplementalFont() { Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont52 = new A.SupplementalFont() { Script = "Arab", Typeface = "Arial" };
            A.SupplementalFont supplementalFont53 = new A.SupplementalFont() { Script = "Hebr", Typeface = "Arial" };
            A.SupplementalFont supplementalFont54 = new A.SupplementalFont() { Script = "Thai", Typeface = "Cordia New" };
            A.SupplementalFont supplementalFont55 = new A.SupplementalFont() { Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont56 = new A.SupplementalFont() { Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont57 = new A.SupplementalFont() { Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont58 = new A.SupplementalFont() { Script = "Khmr", Typeface = "DaunPenh" };
            A.SupplementalFont supplementalFont59 = new A.SupplementalFont() { Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont60 = new A.SupplementalFont() { Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont61 = new A.SupplementalFont() { Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont62 = new A.SupplementalFont() { Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont63 = new A.SupplementalFont() { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont64 = new A.SupplementalFont() { Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont65 = new A.SupplementalFont() { Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont66 = new A.SupplementalFont() { Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont67 = new A.SupplementalFont() { Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont68 = new A.SupplementalFont() { Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont69 = new A.SupplementalFont() { Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont70 = new A.SupplementalFont() { Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont71 = new A.SupplementalFont() { Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont72 = new A.SupplementalFont() { Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont73 = new A.SupplementalFont() { Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont74 = new A.SupplementalFont() { Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont75 = new A.SupplementalFont() { Script = "Viet", Typeface = "Arial" };
            A.SupplementalFont supplementalFont76 = new A.SupplementalFont() { Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont77 = new A.SupplementalFont() { Script = "Geor", Typeface = "Sylfaen" };
            A.SupplementalFont supplementalFont78 = new A.SupplementalFont() { Script = "Armn", Typeface = "Arial" };
            A.SupplementalFont supplementalFont79 = new A.SupplementalFont() { Script = "Bugi", Typeface = "Leelawadee UI" };
            A.SupplementalFont supplementalFont80 = new A.SupplementalFont() { Script = "Bopo", Typeface = "Microsoft JhengHei" };
            A.SupplementalFont supplementalFont81 = new A.SupplementalFont() { Script = "Java", Typeface = "Javanese Text" };
            A.SupplementalFont supplementalFont82 = new A.SupplementalFont() { Script = "Lisu", Typeface = "Segoe UI" };
            A.SupplementalFont supplementalFont83 = new A.SupplementalFont() { Script = "Mymr", Typeface = "Myanmar Text" };
            A.SupplementalFont supplementalFont84 = new A.SupplementalFont() { Script = "Nkoo", Typeface = "Ebrima" };
            A.SupplementalFont supplementalFont85 = new A.SupplementalFont() { Script = "Olck", Typeface = "Nirmala UI" };
            A.SupplementalFont supplementalFont86 = new A.SupplementalFont() { Script = "Osma", Typeface = "Ebrima" };
            A.SupplementalFont supplementalFont87 = new A.SupplementalFont() { Script = "Phag", Typeface = "Phagspa" };
            A.SupplementalFont supplementalFont88 = new A.SupplementalFont() { Script = "Syrn", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont89 = new A.SupplementalFont() { Script = "Syrj", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont90 = new A.SupplementalFont() { Script = "Syre", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont91 = new A.SupplementalFont() { Script = "Sora", Typeface = "Nirmala UI" };
            A.SupplementalFont supplementalFont92 = new A.SupplementalFont() { Script = "Tale", Typeface = "Microsoft Tai Le" };
            A.SupplementalFont supplementalFont93 = new A.SupplementalFont() { Script = "Talu", Typeface = "Microsoft New Tai Lue" };
            A.SupplementalFont supplementalFont94 = new A.SupplementalFont() { Script = "Tfng", Typeface = "Ebrima" };

            minorFont1.Append(latinFont2);
            minorFont1.Append(eastAsianFont2);
            minorFont1.Append(complexScriptFont2);
            minorFont1.Append(supplementalFont48);
            minorFont1.Append(supplementalFont49);
            minorFont1.Append(supplementalFont50);
            minorFont1.Append(supplementalFont51);
            minorFont1.Append(supplementalFont52);
            minorFont1.Append(supplementalFont53);
            minorFont1.Append(supplementalFont54);
            minorFont1.Append(supplementalFont55);
            minorFont1.Append(supplementalFont56);
            minorFont1.Append(supplementalFont57);
            minorFont1.Append(supplementalFont58);
            minorFont1.Append(supplementalFont59);
            minorFont1.Append(supplementalFont60);
            minorFont1.Append(supplementalFont61);
            minorFont1.Append(supplementalFont62);
            minorFont1.Append(supplementalFont63);
            minorFont1.Append(supplementalFont64);
            minorFont1.Append(supplementalFont65);
            minorFont1.Append(supplementalFont66);
            minorFont1.Append(supplementalFont67);
            minorFont1.Append(supplementalFont68);
            minorFont1.Append(supplementalFont69);
            minorFont1.Append(supplementalFont70);
            minorFont1.Append(supplementalFont71);
            minorFont1.Append(supplementalFont72);
            minorFont1.Append(supplementalFont73);
            minorFont1.Append(supplementalFont74);
            minorFont1.Append(supplementalFont75);
            minorFont1.Append(supplementalFont76);
            minorFont1.Append(supplementalFont77);
            minorFont1.Append(supplementalFont78);
            minorFont1.Append(supplementalFont79);
            minorFont1.Append(supplementalFont80);
            minorFont1.Append(supplementalFont81);
            minorFont1.Append(supplementalFont82);
            minorFont1.Append(supplementalFont83);
            minorFont1.Append(supplementalFont84);
            minorFont1.Append(supplementalFont85);
            minorFont1.Append(supplementalFont86);
            minorFont1.Append(supplementalFont87);
            minorFont1.Append(supplementalFont88);
            minorFont1.Append(supplementalFont89);
            minorFont1.Append(supplementalFont90);
            minorFont1.Append(supplementalFont91);
            minorFont1.Append(supplementalFont92);
            minorFont1.Append(supplementalFont93);
            minorFont1.Append(supplementalFont94);

            fontScheme1.Append(majorFont1);
            fontScheme1.Append(minorFont1);

            A.FormatScheme formatScheme1 = new A.FormatScheme() { Name = "Office" };

            A.FillStyleList fillStyleList1 = new A.FillStyleList();

            A.SolidFill solidFill1 = new A.SolidFill();
            A.SchemeColor schemeColor24 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill1.Append(schemeColor24);

            A.GradientFill gradientFill1 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList1 = new A.GradientStopList();

            A.GradientStop gradientStop1 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor25 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation1 = new A.LuminanceModulation() { Val = 110000 };
            A.SaturationModulation saturationModulation1 = new A.SaturationModulation() { Val = 105000 };
            A.Tint tint1 = new A.Tint() { Val = 67000 };

            schemeColor25.Append(luminanceModulation1);
            schemeColor25.Append(saturationModulation1);
            schemeColor25.Append(tint1);

            gradientStop1.Append(schemeColor25);

            A.GradientStop gradientStop2 = new A.GradientStop() { Position = 50000 };

            A.SchemeColor schemeColor26 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation2 = new A.LuminanceModulation() { Val = 105000 };
            A.SaturationModulation saturationModulation2 = new A.SaturationModulation() { Val = 103000 };
            A.Tint tint2 = new A.Tint() { Val = 73000 };

            schemeColor26.Append(luminanceModulation2);
            schemeColor26.Append(saturationModulation2);
            schemeColor26.Append(tint2);

            gradientStop2.Append(schemeColor26);

            A.GradientStop gradientStop3 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor27 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation3 = new A.LuminanceModulation() { Val = 105000 };
            A.SaturationModulation saturationModulation3 = new A.SaturationModulation() { Val = 109000 };
            A.Tint tint3 = new A.Tint() { Val = 81000 };

            schemeColor27.Append(luminanceModulation3);
            schemeColor27.Append(saturationModulation3);
            schemeColor27.Append(tint3);

            gradientStop3.Append(schemeColor27);

            gradientStopList1.Append(gradientStop1);
            gradientStopList1.Append(gradientStop2);
            gradientStopList1.Append(gradientStop3);
            A.LinearGradientFill linearGradientFill1 = new A.LinearGradientFill() { Angle = 5400000, Scaled = false };

            gradientFill1.Append(gradientStopList1);
            gradientFill1.Append(linearGradientFill1);

            A.GradientFill gradientFill2 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList2 = new A.GradientStopList();

            A.GradientStop gradientStop4 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor28 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.SaturationModulation saturationModulation4 = new A.SaturationModulation() { Val = 103000 };
            A.LuminanceModulation luminanceModulation4 = new A.LuminanceModulation() { Val = 102000 };
            A.Tint tint4 = new A.Tint() { Val = 94000 };

            schemeColor28.Append(saturationModulation4);
            schemeColor28.Append(luminanceModulation4);
            schemeColor28.Append(tint4);

            gradientStop4.Append(schemeColor28);

            A.GradientStop gradientStop5 = new A.GradientStop() { Position = 50000 };

            A.SchemeColor schemeColor29 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.SaturationModulation saturationModulation5 = new A.SaturationModulation() { Val = 110000 };
            A.LuminanceModulation luminanceModulation5 = new A.LuminanceModulation() { Val = 100000 };
            A.Shade shade1 = new A.Shade() { Val = 100000 };

            schemeColor29.Append(saturationModulation5);
            schemeColor29.Append(luminanceModulation5);
            schemeColor29.Append(shade1);

            gradientStop5.Append(schemeColor29);

            A.GradientStop gradientStop6 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor30 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation6 = new A.LuminanceModulation() { Val = 99000 };
            A.SaturationModulation saturationModulation6 = new A.SaturationModulation() { Val = 120000 };
            A.Shade shade2 = new A.Shade() { Val = 78000 };

            schemeColor30.Append(luminanceModulation6);
            schemeColor30.Append(saturationModulation6);
            schemeColor30.Append(shade2);

            gradientStop6.Append(schemeColor30);

            gradientStopList2.Append(gradientStop4);
            gradientStopList2.Append(gradientStop5);
            gradientStopList2.Append(gradientStop6);
            A.LinearGradientFill linearGradientFill2 = new A.LinearGradientFill() { Angle = 5400000, Scaled = false };

            gradientFill2.Append(gradientStopList2);
            gradientFill2.Append(linearGradientFill2);

            fillStyleList1.Append(solidFill1);
            fillStyleList1.Append(gradientFill1);
            fillStyleList1.Append(gradientFill2);

            A.LineStyleList lineStyleList1 = new A.LineStyleList();

            A.Outline outline19 = new A.Outline() { Width = 6350, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill2 = new A.SolidFill();
            A.SchemeColor schemeColor31 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill2.Append(schemeColor31);
            A.PresetDash presetDash1 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };
            A.Miter miter1 = new A.Miter() { Limit = 800000 };

            outline19.Append(solidFill2);
            outline19.Append(presetDash1);
            outline19.Append(miter1);

            A.Outline outline20 = new A.Outline() { Width = 12700, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill3 = new A.SolidFill();
            A.SchemeColor schemeColor32 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill3.Append(schemeColor32);
            A.PresetDash presetDash2 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };
            A.Miter miter2 = new A.Miter() { Limit = 800000 };

            outline20.Append(solidFill3);
            outline20.Append(presetDash2);
            outline20.Append(miter2);

            A.Outline outline21 = new A.Outline() { Width = 19050, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill4 = new A.SolidFill();
            A.SchemeColor schemeColor33 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill4.Append(schemeColor33);
            A.PresetDash presetDash3 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };
            A.Miter miter3 = new A.Miter() { Limit = 800000 };

            outline21.Append(solidFill4);
            outline21.Append(presetDash3);
            outline21.Append(miter3);

            lineStyleList1.Append(outline19);
            lineStyleList1.Append(outline20);
            lineStyleList1.Append(outline21);

            A.EffectStyleList effectStyleList1 = new A.EffectStyleList();

            A.EffectStyle effectStyle1 = new A.EffectStyle();
            A.EffectList effectList1 = new A.EffectList();

            effectStyle1.Append(effectList1);

            A.EffectStyle effectStyle2 = new A.EffectStyle();
            A.EffectList effectList2 = new A.EffectList();

            effectStyle2.Append(effectList2);

            A.EffectStyle effectStyle3 = new A.EffectStyle();

            A.EffectList effectList3 = new A.EffectList();

            A.OuterShadow outerShadow1 = new A.OuterShadow() { BlurRadius = 57150L, Distance = 19050L, Direction = 5400000, Alignment = A.RectangleAlignmentValues.Center, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex44 = new A.RgbColorModelHex() { Val = "000000" };
            A.Alpha alpha16 = new A.Alpha() { Val = 63000 };

            rgbColorModelHex44.Append(alpha16);

            outerShadow1.Append(rgbColorModelHex44);

            effectList3.Append(outerShadow1);

            effectStyle3.Append(effectList3);

            effectStyleList1.Append(effectStyle1);
            effectStyleList1.Append(effectStyle2);
            effectStyleList1.Append(effectStyle3);

            A.BackgroundFillStyleList backgroundFillStyleList1 = new A.BackgroundFillStyleList();

            A.SolidFill solidFill5 = new A.SolidFill();
            A.SchemeColor schemeColor34 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill5.Append(schemeColor34);

            A.SolidFill solidFill6 = new A.SolidFill();

            A.SchemeColor schemeColor35 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint5 = new A.Tint() { Val = 95000 };
            A.SaturationModulation saturationModulation7 = new A.SaturationModulation() { Val = 170000 };

            schemeColor35.Append(tint5);
            schemeColor35.Append(saturationModulation7);

            solidFill6.Append(schemeColor35);

            A.GradientFill gradientFill3 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList3 = new A.GradientStopList();

            A.GradientStop gradientStop7 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor36 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint6 = new A.Tint() { Val = 93000 };
            A.SaturationModulation saturationModulation8 = new A.SaturationModulation() { Val = 150000 };
            A.Shade shade3 = new A.Shade() { Val = 98000 };
            A.LuminanceModulation luminanceModulation7 = new A.LuminanceModulation() { Val = 102000 };

            schemeColor36.Append(tint6);
            schemeColor36.Append(saturationModulation8);
            schemeColor36.Append(shade3);
            schemeColor36.Append(luminanceModulation7);

            gradientStop7.Append(schemeColor36);

            A.GradientStop gradientStop8 = new A.GradientStop() { Position = 50000 };

            A.SchemeColor schemeColor37 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint7 = new A.Tint() { Val = 98000 };
            A.SaturationModulation saturationModulation9 = new A.SaturationModulation() { Val = 130000 };
            A.Shade shade4 = new A.Shade() { Val = 90000 };
            A.LuminanceModulation luminanceModulation8 = new A.LuminanceModulation() { Val = 103000 };

            schemeColor37.Append(tint7);
            schemeColor37.Append(saturationModulation9);
            schemeColor37.Append(shade4);
            schemeColor37.Append(luminanceModulation8);

            gradientStop8.Append(schemeColor37);

            A.GradientStop gradientStop9 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor38 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade5 = new A.Shade() { Val = 63000 };
            A.SaturationModulation saturationModulation10 = new A.SaturationModulation() { Val = 120000 };

            schemeColor38.Append(shade5);
            schemeColor38.Append(saturationModulation10);

            gradientStop9.Append(schemeColor38);

            gradientStopList3.Append(gradientStop7);
            gradientStopList3.Append(gradientStop8);
            gradientStopList3.Append(gradientStop9);
            A.LinearGradientFill linearGradientFill3 = new A.LinearGradientFill() { Angle = 5400000, Scaled = false };

            gradientFill3.Append(gradientStopList3);
            gradientFill3.Append(linearGradientFill3);

            backgroundFillStyleList1.Append(solidFill5);
            backgroundFillStyleList1.Append(solidFill6);
            backgroundFillStyleList1.Append(gradientFill3);

            formatScheme1.Append(fillStyleList1);
            formatScheme1.Append(lineStyleList1);
            formatScheme1.Append(effectStyleList1);
            formatScheme1.Append(backgroundFillStyleList1);

            themeElements1.Append(colorScheme1);
            themeElements1.Append(fontScheme1);
            themeElements1.Append(formatScheme1);
            A.ObjectDefaults objectDefaults1 = new A.ObjectDefaults();
            A.ExtraColorSchemeList extraColorSchemeList1 = new A.ExtraColorSchemeList();

            A.OfficeStyleSheetExtensionList officeStyleSheetExtensionList1 = new A.OfficeStyleSheetExtensionList();

            A.OfficeStyleSheetExtension officeStyleSheetExtension1 = new A.OfficeStyleSheetExtension() { Uri = "{05A4C25C-085E-4340-85A3-A5531E510DB2}" };

            Thm15.ThemeFamily themeFamily1 = new Thm15.ThemeFamily() { Name = "Office Theme", Id = "{62F939B6-93AF-4DB8-9C6B-D6C7DFDC589F}", Vid = "{4A3C46E8-61CC-4603-A589-7422A47A8E4A}" };
            themeFamily1.AddNamespaceDeclaration("thm15", "http://schemas.microsoft.com/office/thememl/2012/main");

            officeStyleSheetExtension1.Append(themeFamily1);

            officeStyleSheetExtensionList1.Append(officeStyleSheetExtension1);

            theme1.Append(themeElements1);
            theme1.Append(objectDefaults1);
            theme1.Append(extraColorSchemeList1);
            theme1.Append(officeStyleSheetExtensionList1);

            themePart1.Theme = theme1;
        }

        // Generates content of fontTablePart1.
        private void GenerateFontTablePart1Content(FontTablePart fontTablePart1)
        {
            Fonts fonts1 = new Fonts() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 w15 w16se w16cid" } };
            fonts1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            fonts1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            fonts1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            fonts1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            fonts1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");
            fonts1.AddNamespaceDeclaration("w16cid", "http://schemas.microsoft.com/office/word/2016/wordml/cid");
            fonts1.AddNamespaceDeclaration("w16se", "http://schemas.microsoft.com/office/word/2015/wordml/symex");

            Font font1 = new Font() { Name = "Calibri" };
            Panose1Number panose1Number1 = new Panose1Number() { Val = "020F0502020204030204" };
            FontCharSet fontCharSet1 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily1 = new FontFamily() { Val = FontFamilyValues.Swiss };
            Pitch pitch1 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature1 = new FontSignature() { UnicodeSignature0 = "E4002EFF", UnicodeSignature1 = "C000247B", UnicodeSignature2 = "00000009", UnicodeSignature3 = "00000000", CodePageSignature0 = "000001FF", CodePageSignature1 = "00000000" };

            font1.Append(panose1Number1);
            font1.Append(fontCharSet1);
            font1.Append(fontFamily1);
            font1.Append(pitch1);
            font1.Append(fontSignature1);

            Font font2 = new Font() { Name = "Times New Roman" };
            Panose1Number panose1Number2 = new Panose1Number() { Val = "02020603050405020304" };
            FontCharSet fontCharSet2 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily2 = new FontFamily() { Val = FontFamilyValues.Roman };
            Pitch pitch2 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature2 = new FontSignature() { UnicodeSignature0 = "E0002EFF", UnicodeSignature1 = "C000785B", UnicodeSignature2 = "00000009", UnicodeSignature3 = "00000000", CodePageSignature0 = "000001FF", CodePageSignature1 = "00000000" };

            font2.Append(panose1Number2);
            font2.Append(fontCharSet2);
            font2.Append(fontFamily2);
            font2.Append(pitch2);
            font2.Append(fontSignature2);

            Font font3 = new Font() { Name = "Calibri Light" };
            Panose1Number panose1Number3 = new Panose1Number() { Val = "020F0302020204030204" };
            FontCharSet fontCharSet3 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily3 = new FontFamily() { Val = FontFamilyValues.Swiss };
            Pitch pitch3 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature3 = new FontSignature() { UnicodeSignature0 = "E4002EFF", UnicodeSignature1 = "C000247B", UnicodeSignature2 = "00000009", UnicodeSignature3 = "00000000", CodePageSignature0 = "000001FF", CodePageSignature1 = "00000000" };

            font3.Append(panose1Number3);
            font3.Append(fontCharSet3);
            font3.Append(fontFamily3);
            font3.Append(pitch3);
            font3.Append(fontSignature3);

            fonts1.Append(font1);
            fonts1.Append(font2);
            fonts1.Append(font3);

            fontTablePart1.Fonts = fonts1;
        }

        private void SetPackageProperties(OpenXmlPackage document)
        {
            document.PackageProperties.Creator = "Dragon1983@yandex.ru";
            document.PackageProperties.Title = "";
            document.PackageProperties.Subject = "";
            document.PackageProperties.Keywords = "";
            document.PackageProperties.Description = "";
            document.PackageProperties.Revision = "2";
            document.PackageProperties.Created = System.Xml.XmlConvert.ToDateTime("2019-10-31T10:47:00Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.Modified = System.Xml.XmlConvert.ToDateTime("2019-10-31T10:49:00Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.LastModifiedBy = "Dragon1983@yandex.ru";
        }


    }
}

