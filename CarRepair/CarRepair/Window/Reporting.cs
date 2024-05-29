using CarRepair.Base;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace CarRepair.Window
{
    public partial class Reporting : Form
    {
        //Имя отчета и источник данных для отчета
        private string reportName;
        private object source;

        public Reporting()
        {
            InitializeComponent();
        }

        //Конструктор, который принимает имя отчета и таблицу данных для отображения
        public Reporting(string reportName, object source)
        {
            InitializeComponent();
            this.reportName = reportName;
            this.source = source;
        }

        private void Reporting_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource(); //создеаем источник отчета
            reportDataSource.Name = "DataSet"; //называем
            //Далее в соответсвии названию отчета привязываем тот или иной шаблон
            switch (reportName)
            {
                case "ClientReport":
                    {
                        //Называем окно
                        this.Text = "Отчет по клиенту";
                        //Указываем шаблон для отображения отчета
                        this.reportViewer.LocalReport.ReportEmbeddedResource = "CarRepair.Window.Report.Clients.rdlc";
                        //Указываем в качестве источника к отчету таблицу
                        var table = source as ReportDataSet.ClientReportDataTable;
                        reportDataSource.Value = table;
                        //Добавляем источник к отчету
                        this.reportViewer.LocalReport.DataSources.Add(reportDataSource);
                    }
                    break;
				case "CarReport":
                    {
                        //Называем окно
                        this.Text = "Отчет по автомобилю";
                        //Указываем шаблон для отображения отчета
                        this.reportViewer.LocalReport.ReportEmbeddedResource = "CarRepair.Window.Report.Cars.rdlc";
                        //Указываем в качестве источника к отчету таблицу
                        var table = source as ReportDataSet.CarReportDataTable;
                        reportDataSource.Value = table;
                        //Добавляем источник к отчету
                        this.reportViewer.LocalReport.DataSources.Add(reportDataSource);
                    }
                    break;
				case "CheckReport":
                    {
                        //Называем окно
                        this.Text = "Отчет по клиенту";
                        //Указываем шаблон для отображения отчета
                        this.reportViewer.LocalReport.ReportEmbeddedResource = "CarRepair.Window.Report.Check.rdlc";
                        //Указываем в качестве источника к отчету таблицу
                        var table = source as ReportDataSet.CheackReportDataTable;
                        reportDataSource.Value = table;
                        //Добавляем источник к отчету
                        this.reportViewer.LocalReport.DataSources.Add(reportDataSource);
                    }
                    break;
                case "WorkReport":
                    {
                        //Называем окно
                        this.Text = "Отчет о работе за период";
                        //Указываем шаблон для отображения отчета
                        this.reportViewer.LocalReport.ReportEmbeddedResource = "CarRepair.Window.Report.Work.rdlc";
                        //Указываем в качестве источника к отчету таблицу
                        var table = source as ReportDataSet.WorkReportDataTable;
                        reportDataSource.Value = table;
                        //Добавляем источник к отчету
                        this.reportViewer.LocalReport.DataSources.Add(reportDataSource);
                    }
                    break;
				case "CharYearReport":
                    {
                        //Называем окно
                        this.Text = "Диаграмма по годам";
                        //Указываем шаблон для отображения отчета
                        this.reportViewer.LocalReport.ReportEmbeddedResource = "CarRepair.Window.Report.CharYear.rdlc";
                        //Указываем в качестве источника к отчету таблицу
                        var table = source as ReportDataSet.CharYearMonthReportDataTable;
                        reportDataSource.Value = table;
                        //Добавляем источник к отчету
                        this.reportViewer.LocalReport.DataSources.Add(reportDataSource);
                    }
                    break;
				case "CharMonthReport":
                    {
                        //Называем окно
                        this.Text = "Диаграмма по месяцам";
                        //Указываем шаблон для отображения отчета
                        this.reportViewer.LocalReport.ReportEmbeddedResource = "CarRepair.Window.Report.CharMonth.rdlc";
                        //Указываем в качестве источника к отчету таблицу
                        var table = source as ReportDataSet.CharYearMonthReportDataTable;
                        reportDataSource.Value = table;
                        //Добавляем источник к отчету
                        this.reportViewer.LocalReport.DataSources.Add(reportDataSource);
                    }
                    break;
				case "CharPeopleReport":
					{
						//Называем окно
						this.Text = "Диаграмма по сотруднику";
						//Указываем шаблон для отображения отчета
						this.reportViewer.LocalReport.ReportEmbeddedResource = "CarRepair.Window.Report.CharPeople.rdlc";
						//Указываем в качестве источника к отчету таблицу
						var table = source as ReportDataSet.CharPeopleReportDataTable;
						reportDataSource.Value = table;
						//Добавляем источник к отчету
						this.reportViewer.LocalReport.DataSources.Add(reportDataSource);
					}
					break;
				case "CharPeoplsReport":
                    {
                        //Называем окно
                        this.Text = "Диаграмма по сотрудникам";
                        //Указываем шаблон для отображения отчета
                        this.reportViewer.LocalReport.ReportEmbeddedResource = "CarRepair.Window.Report.CharPeopls.rdlc";
                        //Указываем в качестве источника к отчету таблицу
                        var table = source as ReportDataSet.CharPeopleReportDataTable;
                        reportDataSource.Value = table;
                        //Добавляем источник к отчету
                        this.reportViewer.LocalReport.DataSources.Add(reportDataSource);
                    }
					break;
			}
            this.reportViewer.RefreshReport();
        }   
    }
}
