#pragma checksum "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c20a8886b72f04dc7777d4f5570a8a871cdba6df"
// <auto-generated/>
#pragma warning disable 1591
namespace CobrosParcial.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Aplicada2\CobrosParcial\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aplicada2\CobrosParcial\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Aplicada2\CobrosParcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Aplicada2\CobrosParcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Aplicada2\CobrosParcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Aplicada2\CobrosParcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Aplicada2\CobrosParcial\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Aplicada2\CobrosParcial\_Imports.razor"
using CobrosParcial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Aplicada2\CobrosParcial\_Imports.razor"
using CobrosParcial.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Aplicada2\CobrosParcial\_Imports.razor"
using CobrosParcial.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Aplicada2\CobrosParcial\_Imports.razor"
using CobrosParcial.BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Cobros")]
    public partial class RCobros : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                 cobro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                                        Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n  ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "card");
                __builder2.AddMarkupContent(9, "\r\n   \r\n        ");
                __builder2.AddMarkupContent(10, "<div class=\"card-header\">\r\n            <h3>Cobrar de Factura</h3>\r\n        </div>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "card-body");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "row");
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-md-6");
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "\r\n                        ");
                __builder2.AddMarkupContent(23, "<label>ID</label>\r\n                        ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "input-group");
                __builder2.AddMarkupContent(26, "\r\n                            ");
                __Blazor.CobrosParcial.Pages.RCobros.TypeInference.CreateInputNumber_0(__builder2, 27, 28, "form-control col-4", 29, 
#nullable restore
#line 17 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                                                       cobro.CobroId

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cobro.CobroId = __value, cobro.CobroId)), 31, () => cobro.CobroId);
                __builder2.AddMarkupContent(32, "\r\n                            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "input-group-append");
                __builder2.AddMarkupContent(35, "\r\n                                ");
                __builder2.OpenElement(36, "button");
                __builder2.AddAttribute(37, "type", "button");
                __builder2.AddAttribute(38, "class", "btn btn-primary input-group-text");
                __builder2.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                                                                                                         Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(40, "\r\n                                    <span class=\"oi oi-zoom-in\"></span> Buscar\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "col-md-6");
                __builder2.AddMarkupContent(48, "\r\n                    ");
                __builder2.AddMarkupContent(49, "<label for=\"LoanDatePicker\">Fecha </label>\r\n                   ");
                __Blazor.CobrosParcial.Pages.RCobros.TypeInference.CreateInputDate_1(__builder2, 50, 51, "form-control", 52, "LoanDatePicker", 53, 
#nullable restore
#line 28 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                                           cobro.Fecha

#line default
#line hidden
#nullable disable
                , 54, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cobro.Fecha = __value, cobro.Fecha)), 55, () => cobro.Fecha);
                __builder2.AddMarkupContent(56, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "row");
                __builder2.AddMarkupContent(61, "\r\n                ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "col-md-6");
                __builder2.AddAttribute(64, "style", "margin-bottom: 25px;");
                __builder2.AddMarkupContent(65, "\r\n                    ");
                __builder2.AddMarkupContent(66, "<label>Cliente</label>\r\n                    ");
                __builder2.OpenElement(67, "select");
                __builder2.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 34 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                                        selectCliente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "class", "form-control");
                __builder2.AddMarkupContent(70, "\r\n                        ");
                __builder2.OpenElement(71, "option");
                __builder2.AddAttribute(72, "value", "0");
                __builder2.AddContent(73, "Elige el Cliente");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n");
#nullable restore
#line 36 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                         foreach (var item in listaClientes)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(75, "                            ");
                __builder2.OpenElement(76, "option");
                __builder2.AddAttribute(77, "value", 
#nullable restore
#line 38 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                                            item.ClienteId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(78, 
#nullable restore
#line 38 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                                                             item.Nombres

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n");
#nullable restore
#line 39 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(80, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                   \r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n            ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "row");
                __builder2.AddAttribute(86, "style", "margin-bottom: 25px;");
                __builder2.AddMarkupContent(87, "\r\n             ");
                __builder2.OpenElement(88, "table");
                __builder2.AddAttribute(89, "class", "table");
                __builder2.AddAttribute(90, "style", "border-bottom: 1px groove;");
                __builder2.AddMarkupContent(91, "\r\n                    ");
                __builder2.AddMarkupContent(92, @"<thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"">Opcion</th>
                            <th scope=""col"">Id</th>
                            <th scope=""col"">Fecha</th>
                            <th scope=""col"">Monto</th>
                            <th scope=""col"">Balance</th>
                            <th scope=""col"">Cobrado</th>
                            <th scope=""col"">Pagar</th>
                        </tr>
                    </thead>
                    ");
                __builder2.OpenElement(93, "tbody");
                __builder2.AddMarkupContent(94, "\r\n");
#nullable restore
#line 59 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                     foreach (var item in listaDuedas)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(95, "                        ");
                __builder2.OpenElement(96, "tr");
                __builder2.AddMarkupContent(97, "\r\n                            ");
                __builder2.AddMarkupContent(98, "<td>Opcion</td>\r\n                            ");
                __builder2.OpenElement(99, "td");
                __builder2.AddContent(100, 
#nullable restore
#line 63 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                                 item.VentaId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                            ");
                __builder2.OpenElement(102, "td");
                __builder2.AddContent(103, 
#nullable restore
#line 64 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                                 item.Fecha

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n                            ");
                __builder2.OpenElement(105, "td");
                __builder2.AddContent(106, 
#nullable restore
#line 65 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                                 item.Monto

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n                            ");
                __builder2.OpenElement(108, "td");
                __builder2.AddContent(109, 
#nullable restore
#line 66 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                                 item.Balance

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n                            ");
                __builder2.OpenElement(111, "td");
                __builder2.OpenElement(112, "input");
                __builder2.AddAttribute(113, "type", "number");
                __builder2.AddAttribute(114, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 67 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                                                                CalculaTotalCobrar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(115, "class", "form-control");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n                            ");
                __builder2.OpenElement(117, "td");
                __builder2.OpenElement(118, "input");
                __builder2.AddAttribute(119, "type", "checkbox");
                __builder2.AddAttribute(120, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 68 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                                                                  CalculaTotalCobrar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(121, "class", "form-control");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n");
#nullable restore
#line 70 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                        totalDeuda += item.Balance;
                      
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(124, "                  \r\n                      \r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n            ");
                __builder2.OpenElement(128, "div");
                __builder2.AddAttribute(129, "class", "row");
                __builder2.AddMarkupContent(130, "\r\n                ");
                __builder2.OpenElement(131, "div");
                __builder2.AddAttribute(132, "class", "col-md-4");
                __builder2.AddMarkupContent(133, "\r\n                    ");
                __builder2.AddMarkupContent(134, "<label>Total Deuda </label>\r\n                   ");
                __builder2.OpenElement(135, "input");
                __builder2.AddAttribute(136, "Value", 
#nullable restore
#line 81 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                                  totalDeuda

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(137, "class", "form-control");
                __builder2.AddAttribute(138, "readonly", true);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n                 ");
                __builder2.OpenElement(141, "div");
                __builder2.AddAttribute(142, "class", "offset-md-3 col-md-4");
                __builder2.AddMarkupContent(143, "\r\n                     ");
                __builder2.AddMarkupContent(144, "<label>Monto que esta pagando</label>\r\n                     ");
                __Blazor.CobrosParcial.Pages.RCobros.TypeInference.CreateInputNumber_2(__builder2, 145, 146, true, 147, "form-control col-4", 148, 
#nullable restore
#line 85 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                                                cobro.MontoCobrado

#line default
#line hidden
#nullable disable
                , 149, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cobro.MontoCobrado = __value, cobro.MontoCobrado)), 150, () => cobro.MontoCobrado);
                __builder2.AddMarkupContent(151, "\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(153, "\r\n        ");
                __builder2.OpenElement(154, "div");
                __builder2.AddAttribute(155, "class", "row");
                __builder2.AddMarkupContent(156, "\r\n            ");
                __builder2.OpenElement(157, "div");
                __builder2.AddAttribute(158, "class", "col-md-6");
                __builder2.AddMarkupContent(159, "\r\n            ");
                __builder2.AddMarkupContent(160, "<label>Observaciones</label>\r\n                ");
                __builder2.OpenElement(161, "textarea");
                __builder2.AddAttribute(162, "class", "form-control");
                __builder2.AddAttribute(163, "rows", "5");
                __builder2.AddAttribute(164, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 92 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                                  cobro.Observaciones

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(165, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cobro.Observaciones = __value, cobro.Observaciones));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(166, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(167, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(168, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(169, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(170, "\r\n         ");
                __builder2.OpenElement(171, "div");
                __builder2.AddAttribute(172, "class", "card-footer");
                __builder2.AddMarkupContent(173, "\r\n            ");
                __builder2.OpenElement(174, "div");
                __builder2.AddAttribute(175, "class", "form-group text-center");
                __builder2.AddAttribute(176, "display:", true);
                __builder2.AddAttribute(177, "inline-block", true);
                __builder2.AddMarkupContent(178, "\r\n\r\n                ");
                __builder2.OpenElement(179, "button");
                __builder2.AddAttribute(180, "type", "button");
                __builder2.AddAttribute(181, "class", "btn btn-lg btn-primary");
                __builder2.AddAttribute(182, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 100 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                                                                               Nuevo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(183, "\r\n                    <span class=\"oi oi-plus\"></span> Nuevo\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(184, "\r\n\r\n                ");
                __builder2.AddMarkupContent(185, "<button type=\"submit\" class=\"btn btn-lg btn-success\">\r\n                    <span class=\"oi oi-clipboard\" aria-hidden=\"true\"></span> Guardar\r\n                </button>\r\n\r\n                ");
                __builder2.OpenElement(186, "button");
                __builder2.AddAttribute(187, "type", "button");
                __builder2.AddAttribute(188, "class", "btn btn-lg btn-danger");
                __builder2.AddAttribute(189, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
                                                                              Eliminar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(190, "\r\n                    <span class=\"oi oi-trash\"></span>   Eliminar\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(191, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(192, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(193, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(194, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 117 "C:\Aplicada2\CobrosParcial\Pages\RCobros.razor"
      

  Cobro cobro = new Cobro();
  string prueba;
  int prueba1;
  private string clienteId = string.Empty;
  List<Clientes> listaClientes = new List<Clientes>();
  List<Ventas> listaDuedas = new List<Ventas>();
  double totalDeuda = 0;
  List <double> pago = new List<double>();

   protected override void OnInitialized()
    {
      
        listaClientes = ClienteBLL.GetList(x => true);
    }


  private void Guardar(){

  }

  private void Buscar(){

  }
   private void Nuevo(){

  }

   private void Eliminar(){

  }

   private void selectCliente(ChangeEventArgs e){
    clienteId = e.Value.ToString();
    totalDeuda = 0;
   
    listaDuedas = ClienteBLL.GetVentas(clienteId);
    //cobro.ClienteId =  clienteId;
      
  }

  private void CalculaTotalCobrar(ChangeEventArgs e){
    Console.WriteLine(e.Value.ToString());
  }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.CobrosParcial.Pages.RCobros
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "readonly", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
