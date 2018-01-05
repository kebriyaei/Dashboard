<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TotalSaleCoOptional.ascx.cs" Inherits="WebUserControls_BarOptional_TotalSaleCoOptional" %>

                <div class="col-md-6">
                <div class="panel panel-darkGray">
                    <div class="panel-heading">
                        <h4><i class="fa fa-fw fa-signal"></i>  فروش وزنی ماهیانه  - تن</h4>
                    </div>
                    <div class="panel-body">
                         <div class="btn-group btn-group-sm" role="group" id="OptionalWeight" >
                             <button type="button" class="btn btn-default active"  value="1" >شرکت</button>
                             <button type="button" class="btn btn-paxan"  value="2" >گروه پاکسان</button>
                             <button type="button" class="btn btn-ariamelal"  value="3" >آروین ملل</button>
                             <button type="button" class="btn btn-Masouleh"  value="4" >ماسوله</button>
                             <button type="button" class="btn btn-warning"  value="6" >آفتاب</button>
                             <button type="button" class="btn btn-parsshahab"  value="7" >پارس شهاب</button> 
                             <button type="button" class="btn btn-behpak"  value="8" >بهپاک</button>
                             <button type="button" class="btn btn-other"  value="5" >سایر</button>
                         </div>
                        <p>
                <asp:Literal ID="ltrChartLineCoOptionalWeight" runat="server"></asp:Literal>
                            </p>
                        
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                            <div class="panel panel-darkGray">
                                <div class="panel-heading">
                                    <h4><i class="fa fa-fw fa-signal"></i> فروش ریالی ماهیانه  - میلیون ریال</h4>
                                </div>
                                <div class="panel-body">
                                     <div class="btn-group btn-group-sm" role="group" id="OptionalRial" >
                                         <button type="button" class="btn btn-default active"  value="1" >شرکت</button>
                                         <button type="button" class="btn btn-paxan"  value="2" >گروه پاکسان</button>
                                         <button type="button" class="btn btn-ariamelal"  value="3" >آروین ملل</button>
                                         <button type="button" class="btn btn-Masouleh"  value="4" >ماسوله</button>
                                         <button type="button" class="btn btn-warning"  value="6" >آفتاب</button>
                                         <button type="button" class="btn btn-parsshahab"  value="7" >پارس شهاب</button>
                                         <button type="button" class="btn btn-behpak"  value="8" >بهپاک</button>
                                         <button type="button" class="btn btn-other"  value="5" >سایر</button>
                          
                                     </div>
                                    <p>
                            <asp:Literal ID="ltrChartLineCoOptionalRial" runat="server"></asp:Literal>
                                        </p>
                        
                                </div>
                            </div>
                </div>

