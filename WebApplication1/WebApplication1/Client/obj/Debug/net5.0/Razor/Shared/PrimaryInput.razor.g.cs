#pragma checksum "C:\Users\lewis\Desktop\WebApplication1\WebApplication1\Client\Shared\PrimaryInput.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36121b2a838d953802a2a76c93d96d71967d3807"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lewis\Desktop\WebApplication1\WebApplication1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lewis\Desktop\WebApplication1\WebApplication1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lewis\Desktop\WebApplication1\WebApplication1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lewis\Desktop\WebApplication1\WebApplication1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lewis\Desktop\WebApplication1\WebApplication1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lewis\Desktop\WebApplication1\WebApplication1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lewis\Desktop\WebApplication1\WebApplication1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lewis\Desktop\WebApplication1\WebApplication1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lewis\Desktop\WebApplication1\WebApplication1\Client\_Imports.razor"
using WebApplication1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lewis\Desktop\WebApplication1\WebApplication1\Client\_Imports.razor"
using WebApplication1.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class PrimaryInput : InputBase<string>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(0);
            __builder.AddAttribute(1, "class", "form-control");
            __builder.AddMultipleAttributes(2, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 5 "C:\Users\lewis\Desktop\WebApplication1\WebApplication1\Client\Shared\PrimaryInput.razor"
                        AdditionalAttributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "C:\Users\lewis\Desktop\WebApplication1\WebApplication1\Client\Shared\PrimaryInput.razor"
                        CurrentValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentValue = __value, CurrentValue))));
            __builder.AddAttribute(5, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => CurrentValue));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\lewis\Desktop\WebApplication1\WebApplication1\Client\Shared\PrimaryInput.razor"
        
    protected override bool TryParseValueFromString(string value, [System.Diagnostics.CodeAnalysis.MaybeNullWhen(false)] out string result, [System.Diagnostics.CodeAnalysis.NotNullWhen(false)] out string validationErrorMessage)
    {
            result = value;
            validationErrorMessage = null;

            return true;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591