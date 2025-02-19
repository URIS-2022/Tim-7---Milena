﻿using System;

namespace FastReport.Web
{
    partial class WebReport
    {
        string template_body(bool renderBody)
        {
            if (!renderBody)
                return $@"
<div class=""{template_FR}-body"" style=""min-height:250px;min-width:250px;"">

    <script>
        setTimeout(function () {{
            {template_FR}.load();
        }}, 100);
    </script>

</div>
";

            return $@"
<div class=""{template_FR}-body"">

    {template_outline()}

    <div class=""{template_FR}-report"">
        {ReportBody()}
    </div>
    
";
        }
    }
}
