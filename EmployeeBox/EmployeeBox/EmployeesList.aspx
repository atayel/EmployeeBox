<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeesList.aspx.cs" Inherits="EmployeeBox.EmployeesList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12">
        <!--Top header start-->
        <h3 class="ls-top-header">الموظفين</h3>
        <!--Top header end -->

        <!--Top breadcrumb start -->
        <ol class="breadcrumb">
            <li><a href="/"><i class="fa fa-home"></i></a></li>
            <li class="active">الموظفين</li>
        </ol>
        <!--Top breadcrumb start -->
    </div>
    <div class="col-md-12">
        <div class="panel panel-default">
            <div class="panel-heading">
                <h3 class="panel-title">بحث متقدم</h3>
                <ul class="panel-control">
                    <li><a class="minus" href="javascript:void(0)"><i class="fa fa-minus"></i></a></li>
                    <li><a class="refresh" href="javascript:void(0)"><i class="fa fa-refresh"></i></a></li>
                    <li><a class="close-panel" href="javascript:void(0)"><i class="fa fa-times"></i></a></li>
                </ul>
            </div>

            <div class="panel-body">
                <div class="row">
                    <div class="form-group">
                        <label class="col-md-1 control-label">الإسم</label>
                        <div class="col-md-3">
                            <input type="text" id="txtName" runat="server" class="form-control" />
                        </div>

                        <label class="col-md-1 control-label">الرقم القومى</label>
                        <div class="col-md-3">
                            <input type="text" id="txtNationalID" runat="server" class="form-control" min="00000000000000" max="99999999999999" />
                        </div>


                        <label class="col-md-1 control-label">المؤهل التعليمي</label>
                        <div class="col-md-3">
                            <select id="employeeEducationList" runat="server" class="demo-default selectized selectList">
                            </select>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="form-group">
                        <label class="col-md-3 control-label">تاريخ التعيين من </label>
                        <div class="col-md-3">
                            <input type="text" id="txtHireDateFrom" runat="server" class="form-control datePickerOnly" />
                        </div>

                        <label class="col-md-3 control-label">تاريخ التعيين إلى </label>
                        <div class="col-md-3">
                            <input type="text" id="txtHireDateTo" runat="server" class="form-control datePickerOnly" />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="form-group">
                        <label class="col-md-3 control-label">تاريخ الإنضمام من </label>
                        <div class="col-md-3">
                            <input type="text" id="txtJoinDateFrom" runat="server" class="form-control datePickerOnly" />
                        </div>

                        <label class="col-md-3 control-label">تاريخ الإنضمام إلى </label>
                        <div class="col-md-3">
                            <input type="text" id="txtJoinDateTo" runat="server" class="form-control datePickerOnly" />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="form-group">
                        <label class="col-md-3 control-label">حصة الموظف من</label>
                        <div class="col-md-3">
                            <input type="text" id="txtEmployeeShareFrom" min="0" runat="server" class="form-control"  />
                        </div>
                        <label class="col-md-3 control-label">حصة الموظف الى</label>
                        <div class="col-md-3">
                            <input type="text" id="txtEmployeeShareTo" min="0" runat="server" class="form-control"  />
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <input type="reset" id="btnReset" class="btn btn-danger pull-right" value="إلغاء" />
                    <input type="submit" id="btnSearch" runat="server" onserverclick="btnSearch_ServerClick" class="btn btn-primary pull-right" value="بحث" />
                </div>
            </div>
        </div>
    </div>

    <div class="col-md-12">
        <div class="panel panel-default">
            <div class="panel-heading">
                <h3 class="panel-title">عرض</h3>
                <ul class="panel-control">
                    <li><a class="minus" href="javascript:void(0)"><i class="fa fa-minus"></i></a></li>
                    <li><a class="refresh" href="javascript:void(0)"><i class="fa fa-refresh"></i></a></li>
                    <li><a class="close-panel" href="javascript:void(0)"><i class="fa fa-times"></i></a></li>
                </ul>
            </div>

            <div class="panel-body">
                <div class="table-responsive ls-table">
                    <table class="table table-bordered table-striped">
                        <thead>
                            <tr>
                                <th>
                                    المسلسل
                                </th>
                                <th>
                                    الإسم
                                </th>
                                <th>
                                    صورة الموظف
                                </th>
                                <th>
                                    الصلاحيات
                                </th>
                            </tr>
                        </thead>

                        <tbody runat="server" id="tableBody">
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td class="text-center">
                                    <button class="btn btn-xs btn-success"><i class="fa fa-eye"></i></button>
                                    <button class="btn btn-xs btn-warning"><i class="fa fa-pencil-square-o"></i></button>
                                    <button class="btn btn-xs btn-danger"><i class="fa fa-minus"></i></button>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>


                <div class="table-responsive ls-table">
                    <asp:DataGrid class="table table-bordered table-striped" AllowPaging="true"
                        AllowCustomPaging="true"
                         runat="server" ID="dt">
                        <Columns>
                            <asp:BoundColumn HeaderText="المسلسل" DataField="EmployeeID"></asp:BoundColumn>
                            <asp:BoundColumn HeaderText="الإسم" DataField="Name"></asp:BoundColumn>
                            <asp:BoundColumn HeaderText="صورة الموظف" DataField="Photo"></asp:BoundColumn>
                        </Columns>
                        <PagerStyle CssClass="pagination pagination-sm"/>
                    </asp:DataGrid>
                </div>
            </div>
        </div>
    </div>

    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script>
        $(document).ready(function () {
            $('.selectList').selectize();

            $('.datePickerOnly').datetimepicker({
                timepicker: false,
                datepicker: true,
                mask: '',
                format: 'd/m/Y'
            });
        });
    </script>
</asp:Content>
