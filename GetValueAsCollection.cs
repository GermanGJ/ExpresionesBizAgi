var objVariable = CHelper.GetValueAsCollection(Me.Context.getXPath("MP_SolicitudCH.IdM_CreditoHipotecario.IdM_Codeudor.xReferencias"));
CHelper.trace(sFileName,"size: " + objVariable.size());
if (objVariable.size() > 0)
{
    for (var j = 0; j< objVariable.size(); j++)
    {
        CHelper.trace(sFileName,"Cont CoDeudor Ref: " + j);
        var objetoUnico = objVariable.get(j);
        CHelper.trace(sFileName,"Nombres: " + objetoUnico.getXPath("sNombres"));
    }
}