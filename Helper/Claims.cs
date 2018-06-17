namespace Helper
{
    public class Claims
    {
        readonly GenEjeSp _ejeSp = new GenEjeSp();
        public string ClaimByUser(string id)
        {
            var dt  = _ejeSp.EjecSp("FE_ObtenerClaimsByUsuario_SP", id);

            if (dt.Rows.Count == 0) return null;

            var claim = dt.Rows[0]["ClaimValue"].ToString();

            return claim;
        }
    }
}
