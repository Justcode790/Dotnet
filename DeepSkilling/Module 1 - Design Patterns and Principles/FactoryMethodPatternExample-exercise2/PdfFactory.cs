class PdfFactory : DocumentFactor{
    public override IDocument CreateDocument(){
        return new PdfDocument();
    }
}