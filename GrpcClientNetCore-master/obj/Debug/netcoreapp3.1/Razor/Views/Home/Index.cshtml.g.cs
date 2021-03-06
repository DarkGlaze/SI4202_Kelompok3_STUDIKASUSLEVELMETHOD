#pragma checksum "D:\Apps\XAMPP\htdocs\New folder\GrpcClientNetCore-master\GrpcClientNetCore-master\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bb299c79dd5d99ade63f136b99460fc69abae5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Apps\XAMPP\htdocs\New folder\GrpcClientNetCore-master\GrpcClientNetCore-master\Views\_ViewImports.cshtml"
using GrpcGreeterClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Apps\XAMPP\htdocs\New folder\GrpcClientNetCore-master\GrpcClientNetCore-master\Views\_ViewImports.cshtml"
using GrpcGreeterClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Apps\XAMPP\htdocs\New folder\GrpcClientNetCore-master\GrpcClientNetCore-master\Views\Home\Index.cshtml"
using GrpcGreeterClient.Class;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bb299c79dd5d99ade63f136b99460fc69abae5a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"684c09c4fd9933e7a5c6280d42dbf295f916869d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Mahasiswa>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Apps\XAMPP\htdocs\New folder\GrpcClientNetCore-master\GrpcClientNetCore-master\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
            </div>
        </div>
    </div>
</section>
<section class=""content"">
    <div class=""modal fade"" id=""modal-input"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Input Data</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div id=""progbarinsert"" style=""display:none"">
                        <div id=""loadpageinsert"" style=""padding-top:10px;"">
                            <div class=""loading text-center"">
                                <div class=""loading-bar""></div>
                                <div class=""loading-bar""></di");
            WriteLiteral(@"v>
                                <div class=""loading-bar""></div>
                                <div class=""loading-bar""></div>
                                <div class=""loading-bar""></div>
                                <div class=""loading-bar""></div>
                            </div>
                        </div>
                    </div>
                    <div id=""forminsert"" style=""display:block"">
                        <div class=""form-group"" style=""display:none;"">
                            <input id=""txttipemodal"" class=""form-control"" readonly />
                        </div>
                        <div class=""form-group"">
                            <label>NIM Mahasiswa</label>
                            <input type=""text"" id=""inputtxtnim"" placeholder=""Nim Mahasiswa"" class=""form-control"" />
                        </div>
                        <div class=""form-group"">
                            <label>Nama Mahasiswa</label>
                            <input type=""text"" id=""inputtxtn");
            WriteLiteral(@"ama"" placeholder=""Nama Mahasiswa"" class=""form-control"" />
                        </div>
                        <div class=""form-group"">
                            <label>Asal Mahasiswa</label>
                            <input type=""text"" id=""inputtxtasal"" placeholder=""Asal Mahasiswa"" class=""form-control"" />
                        </div>
                        <div class=""form-group"">
                            <label>Tanggal Lahir</label>
                            <input type=""date"" id=""inputtxttgl"" placeholder=""Tanggal Lahir Mahasiswa"" class=""form-control"" />
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" id=""cancelinsert"" class=""btn btn-default fa-pull-left"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" id=""insertbannerbtn"" onclick=""InsertData()"" class=""btn btn-success"">Save</button>
                </div>
            </div>
        </div>
    </div");
            WriteLiteral(@">
    <div class=""container-fluid"">
        <div class=""card"">
            <div class=""card-header bg-light"">
                <h3 class=""card-title"">List Mahasiswa</h3>
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-12"" style=""padding-bottom:20px;"">
                        <a data-tipe=""I"" class=""btn openmodal btn-primary"" style=""color:white; cursor:pointer;"" title=""Insert"">Tambah Mahasiswa</a>
                    </div>
                </div>
                <table id=""tabledata"" class=""nowrap table table-bordered table-striped"">
                    <thead>
                        <tr>
                            <th>NIM</th>
                            <th>Nama</th>
                            <th>Asal</th>
                            <th>Tanggal Lahir</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 89 "D:\Apps\XAMPP\htdocs\New folder\GrpcClientNetCore-master\GrpcClientNetCore-master\Views\Home\Index.cshtml"
                         foreach (var mhs in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 92 "D:\Apps\XAMPP\htdocs\New folder\GrpcClientNetCore-master\GrpcClientNetCore-master\Views\Home\Index.cshtml"
                               Write(mhs.Nim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 93 "D:\Apps\XAMPP\htdocs\New folder\GrpcClientNetCore-master\GrpcClientNetCore-master\Views\Home\Index.cshtml"
                               Write(mhs.Nama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 94 "D:\Apps\XAMPP\htdocs\New folder\GrpcClientNetCore-master\GrpcClientNetCore-master\Views\Home\Index.cshtml"
                               Write(mhs.Asal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 95 "D:\Apps\XAMPP\htdocs\New folder\GrpcClientNetCore-master\GrpcClientNetCore-master\Views\Home\Index.cshtml"
                               Write(mhs.Datebirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td style=\"text-align:center\">\n                                    <div class=\"btn-group\">\n                                        <a");
            BeginWriteAttribute("id", " id=\"", 4626, "\"", 4639, 1);
#nullable restore
#line 98 "D:\Apps\XAMPP\htdocs\New folder\GrpcClientNetCore-master\GrpcClientNetCore-master\Views\Home\Index.cshtml"
WriteAttributeValue("", 4631, mhs.Nim, 4631, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-user=\"");
#nullable restore
#line 98 "D:\Apps\XAMPP\htdocs\New folder\GrpcClientNetCore-master\GrpcClientNetCore-master\Views\Home\Index.cshtml"
                                                               Write(mhs.Nim);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-tipe=\"E\" class=\"btn btn-success openedit\" style=\"color:white; cursor:pointer;\" title=\"Edit\"><i class=\"far fa-edit\"></i></a>\n                                        <a data-id=\"");
#nullable restore
#line 99 "D:\Apps\XAMPP\htdocs\New folder\GrpcClientNetCore-master\GrpcClientNetCore-master\Views\Home\Index.cshtml"
                                               Write(mhs.Nim);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-title=\"");
#nullable restore
#line 99 "D:\Apps\XAMPP\htdocs\New folder\GrpcClientNetCore-master\GrpcClientNetCore-master\Views\Home\Index.cshtml"
                                                                     Write(mhs.Nama);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-danger DeletePromo\" style=\"color:white; cursor:pointer;\" title=\"Delete\"><i class=\"far fa-trash-alt\"></i></a>\n                                    </div>\n                                </td>\n                            </tr>\n");
#nullable restore
#line 103 "D:\Apps\XAMPP\htdocs\New folder\GrpcClientNetCore-master\GrpcClientNetCore-master\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
    </div>
</section>

<script>
    $(function () {
        $('#tabledata').DataTable({
            ""lengthMenu"": [[5, 15, 25, 50, -1], [5, 15, 25, 50, ""All""]],
            ""responsive"": true,
            ""ordering"": true
        });
    });

    function clearform() {
        document.getElementById(""inputtxtnim"").value = """";
        document.getElementById(""inputtxtnama"").value = """";
        document.getElementById(""inputtxttgl"").value = """";
        document.getElementById(""inputtxtasal"").value = """";
    }

    $(document).on(""click"", "".openmodal"", function () {
        clearform();
        var myID = $(this).data('tipe');
        document.getElementById(""txttipemodal"").value = myID;
        $(""#modal-input"").modal({ backdrop: ""static"" });
    });

    $(document).on(""click"", "".openedit"", function () {
        clearform();
        document.getElementById(""insertbannerbtn"").disabled = true;
        document.getElementById");
            WriteLiteral(@"(""progbarinsert"").style.display = ""block"";
        document.getElementById(""forminsert"").style.display = ""none"";
        var tipe = $(this).data('tipe');
        var nim = $(this).data('user');
        document.getElementById(""txttipemodal"").value = tipe;
        var str = ""nim="" + nim;

        $.ajax({
            type: ""POST"",
            url: ""GetDetailMahasiswa?"" + str,
            contentType: ""application/json; charset=utf-8"",
            success: function (response) {
                var d = response;
                console.log(d);
                document.getElementById(""inputtxtnim"").readOnly = true;
                document.getElementById(""inputtxtnim"").value = d[""nim""];
                document.getElementById(""inputtxtnama"").value = d[""nama""];
                document.getElementById(""inputtxtasal"").value = d[""asal""];
                var tgl = moment(d[""datebirth""], 'DD/MM/YY').format('YYYY-MM-DD');
                console.log(tgl);
                document.getElementById(""inputtxttgl"").value = tg");
            WriteLiteral(@"l;

                document.getElementById(""insertbannerbtn"").disabled = false;
                document.getElementById(""progbarinsert"").style.display = ""none"";
                document.getElementById(""forminsert"").style.display = ""block"";
            },
            failure: function (response) {
                alert(response.d);
            }
        });
        $(""#modal-input"").modal({ backdrop: ""static"" });
    });

    $(document).on(""click"", "".DeletePromo"", function () {
        var myID = $(this).data('id');
        var title = $(this).data('title');
        if (confirm(""Apakah anda yakin ingin menghapus "" + title + ""?"")) {
            var str = ""nim="" + myID;
            $.ajax({
                type: ""POST"",
                url: ""DeleteMahasiswa?"" + str,
                contentType: ""application/json; charset=utf-8"",
                success: function (response) {
                    var d = response;
                    if (d.split(""~"")[0] == ""1"") {
                        alert(d.split(""~"")[1]);
 ");
            WriteLiteral(@"                   } else if (d.split(""~"")[0] == ""0"") {
                        alert(d.split(""~"")[1]);
                        location.reload();
                    }
                },
                failure: function (response) {
                    alert(response.d);
                }
            });
        }
    });

    function InsertData() {
        document.getElementById(""insertbannerbtn"").disabled = true;
        document.getElementById(""progbarinsert"").style.display = ""block"";
        document.getElementById(""forminsert"").style.display = ""none"";
        document.getElementById(""cancelinsert"").style.display = ""none"";

        var nim = document.getElementById(""inputtxtnim"").value;
        var nama = document.getElementById(""inputtxtnama"").value;
        var asal = document.getElementById(""inputtxtasal"").value;
        var tanggal = document.getElementById(""inputtxttgl"").value;
        tgl = moment(tanggal, 'YYYY-MM-DD').format('MM/DD/YY').toString();

        var param = {};
        param.nama =");
            WriteLiteral(@" nama;
        param.nim = nim;
        param.asal = asal;
        param.datebirth = tgl;

        var t = document.getElementById(""txttipemodal"").value;
        var url = """";
        if (t == ""I"") {
            url = ""InsertMahasiswa"";
        }
        else if (t == ""E"") {
            url = ""EditMahasiswa"";
        }
        $.ajax({
            type: ""POST"",
            url: url,
            data: JSON.stringify(param),
            contentType: ""application/json; charset=utf-8"",
            success: function (response) {
                var d = response;
                if (d.split(""~"")[0] == ""1"") {
                    alert(d.split(""~"")[1]);
                    document.getElementById(""insertbannerbtn"").disabled = false;
                    document.getElementById(""progbarinsert"").style.display = ""none"";
                    document.getElementById(""forminsert"").style.display = ""block"";
                    document.getElementById(""cancelinsert"").style.display = ""block"";
                } else if (d.split(""");
            WriteLiteral(@"~"")[0] == ""0"") {
                    console.log(response);
                    alert(d.split(""~"")[1]);
                    location.reload();
                } else if (d.split(""~"")[0] == ""2"") {
                    $(""#modal-edit"").modal(""hide"");
                }
            },
            failure: function (response) {
                alert(response.d);
            }
        });
    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mahasiswa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
