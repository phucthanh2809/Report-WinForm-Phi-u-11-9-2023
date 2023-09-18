using DevExpress.Drawing;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using Report_WinForm_Phiếu_11_9_2023.Model;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Report_WinForm_Phiếu_11_9_2023.Report
{
    public partial class Report_PhieuGayMeHoiSuc : DevExpress.XtraReports.UI.XtraReport
    {
        public Report_PhieuGayMeHoiSuc()
        {
            InitializeComponent();
        }

        private TopMarginBand topMarginBand1;
        private DetailBand detailBand1;
        private BottomMarginBand bottomMarginBand1;
        public void InitData(PhieuGayMeHoiSuc_Model model)
        {
            objectDataSource1.DataSource = model;
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable14 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell119 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell120 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel616 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel615 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel614 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel613 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel612 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable13 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell116 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell118 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel606 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel605 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel604 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel603 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel602 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable12 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell115 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell117 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel334 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel333 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel332 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel331 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel330 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel325 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel324 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel323 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel318 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel629 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrPanel7 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel621 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel620 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel619 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel618 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel617 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel6 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel611 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel610 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel609 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel608 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel607 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel5 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel627 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel626 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel625 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel624 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel623 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel622 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine15 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine14 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine13 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel336 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel335 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel328 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel327 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel326 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel322 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel321 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel320 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel52 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel54 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel319 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable11 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell103 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel529 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel530 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel531 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel532 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel533 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel534 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell104 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel535 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel536 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel537 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel538 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel539 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel540 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell105 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel541 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel542 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel543 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel544 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel545 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel546 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell106 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel547 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel548 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel549 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel550 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel551 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel552 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell107 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel553 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel554 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel555 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel556 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel557 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel558 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell108 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel559 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel560 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel561 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel562 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel563 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel564 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell109 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel565 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel566 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel567 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel568 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel569 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel570 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell110 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel571 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel572 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel573 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel574 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel575 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel576 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell111 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel577 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel578 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel579 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel580 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel581 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel582 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell112 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel583 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel584 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel585 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel586 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel587 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel588 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell113 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel589 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel590 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel591 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel592 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel593 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel594 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell114 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel595 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel596 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel597 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel598 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel599 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel600 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable10 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell91 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel457 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel458 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel459 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel460 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel461 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel462 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell92 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel463 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel464 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel465 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel466 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel467 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel468 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell93 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel469 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel470 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel471 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel472 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel473 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel474 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell94 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel475 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel476 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel477 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel478 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel479 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel480 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell95 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel481 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel482 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel483 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel484 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel485 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel486 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell96 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel487 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel488 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel489 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel490 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel491 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel492 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell97 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel493 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel494 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel495 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel496 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel497 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel498 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell98 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel499 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel500 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel501 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel502 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel503 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel504 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell99 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel505 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel506 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel507 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel508 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel509 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel510 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell100 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel511 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel512 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel513 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel514 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel515 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel516 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell101 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel517 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel518 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel519 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel520 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel521 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel522 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell102 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel523 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel524 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel525 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel526 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel527 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel528 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable9 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell79 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel432 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel433 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel434 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel435 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell81 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel436 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel437 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell82 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel438 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel439 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell83 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel440 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel441 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell84 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine6 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel442 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel443 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell85 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine7 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel444 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel445 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell86 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine8 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel446 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel447 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell87 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine9 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel448 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel449 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell88 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine10 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel450 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel451 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell89 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine11 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel452 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel453 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell90 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine12 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel454 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel455 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable8 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel329 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel337 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel338 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel339 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel342 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel343 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel344 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel345 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel348 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel349 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel350 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel351 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel354 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel355 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel356 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel357 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel360 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel361 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel362 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel363 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel366 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel367 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel368 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel369 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel372 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel373 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel374 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel375 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel378 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel379 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell72 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel380 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel381 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel384 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel385 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel386 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel387 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell73 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel390 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel391 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel392 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel393 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel396 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel397 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell74 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel398 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel399 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel402 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel403 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel404 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel405 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell75 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel408 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel409 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel410 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel411 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel412 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel413 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell76 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel414 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel415 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel416 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel417 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel418 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel419 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel420 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel421 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel422 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel423 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel424 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel425 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell78 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel426 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel427 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel428 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel429 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel430 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel431 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable7 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel340 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel341 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel346 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel347 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel352 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel353 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel358 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel359 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel364 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel365 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel370 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel371 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel376 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel377 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel382 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel383 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel388 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel389 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel394 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel395 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel400 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel401 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel406 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel407 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel295 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel235 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel236 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel237 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel238 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel239 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel296 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel240 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel241 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel242 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel243 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel244 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel297 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel245 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel246 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel247 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel248 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel249 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel298 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel250 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel251 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel252 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel253 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel254 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel299 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel255 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel256 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel257 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel258 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel259 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel300 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel260 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel261 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel262 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel263 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel264 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel301 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel265 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel266 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel267 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel268 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel269 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel302 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel270 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel271 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel272 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel273 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel274 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel303 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel275 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel276 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel277 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel278 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel279 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel304 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel280 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel281 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel282 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel283 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel284 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel305 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel285 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel286 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel287 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel288 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel289 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel306 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel290 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel291 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel292 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel293 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel294 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel175 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel176 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel177 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel178 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel179 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel180 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel181 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel182 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel183 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel184 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel185 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel186 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel187 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel188 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel189 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel190 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel191 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel192 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel193 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel194 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel195 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel196 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel197 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel198 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel199 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel200 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel201 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel202 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel203 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel204 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel205 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel206 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel207 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel208 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel209 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel210 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel211 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel212 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel213 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel214 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel215 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel216 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel217 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel218 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel219 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel220 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel221 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel222 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel223 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel224 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel225 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel226 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel227 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel228 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel229 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel230 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel231 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel232 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel233 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel234 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel55 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel56 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel57 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel58 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel59 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel60 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel62 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel63 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel64 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel65 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel66 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel127 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel128 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel129 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel130 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel131 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel132 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel133 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel134 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel135 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel136 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel137 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel138 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel139 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel140 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel141 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel142 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel143 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel144 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel145 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel146 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel147 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel148 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel149 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel150 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel151 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel152 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel153 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel154 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel155 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel156 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel157 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel158 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel159 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel160 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel161 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel162 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel163 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel164 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel165 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel166 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel167 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel168 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel169 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel170 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel171 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel172 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel173 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel174 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel71 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel70 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel69 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel68 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel67 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel72 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel73 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel74 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel75 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel76 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel77 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel78 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel79 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel80 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel81 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel82 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel83 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel84 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel85 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel86 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel87 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel88 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel89 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel90 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel91 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel92 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel93 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel94 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel95 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel96 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel97 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel98 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel99 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel100 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel101 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel102 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel103 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel104 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel105 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel106 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel107 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel108 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel109 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel110 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel111 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel112 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel113 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel114 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel115 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel116 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel117 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel118 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel119 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel120 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel121 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel122 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel123 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel124 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel125 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel126 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel311 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel310 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel309 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel308 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel307 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel312 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel313 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel314 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel315 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel316 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel601 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel4 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel456 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel317 = new DevExpress.XtraReports.UI.XRLabel();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCheckBox2 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCheckBox1 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 75.00001F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.detailBand1.HeightF = 721.0813F;
            this.detailBand1.Name = "detailBand1";
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0.299232F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(726.7006F, 721.0813F);
            this.xrTable1.StylePriority.UseBorders = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable14,
            this.xrTable13,
            this.xrTable12,
            this.xrLabel334,
            this.xrLabel333,
            this.xrLabel332,
            this.xrLabel331,
            this.xrLabel330,
            this.xrLabel325,
            this.xrLabel324,
            this.xrLabel323,
            this.xrLabel318,
            this.xrLabel47,
            this.xrLabel629});
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.Weight = 0.95361290104208185D;
            // 
            // xrTable14
            // 
            this.xrTable14.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable14.LocationFloat = new DevExpress.Utils.PointFloat(0.2477786F, 568F);
            this.xrTable14.Name = "xrTable14";
            this.xrTable14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable14.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow14});
            this.xrTable14.SizeF = new System.Drawing.SizeF(173F, 91.5F);
            this.xrTable14.StylePriority.UseBorders = false;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell119,
            this.xrTableCell120});
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.Weight = 1D;
            // 
            // xrTableCell119
            // 
            this.xrTableCell119.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell119.Multiline = true;
            this.xrTableCell119.Name = "xrTableCell119";
            this.xrTableCell119.StylePriority.UseFont = false;
            this.xrTableCell119.StylePriority.UseTextAlignment = false;
            this.xrTableCell119.Text = "Dịch truyền";
            this.xrTableCell119.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell119.Weight = 0.51205179459007255D;
            // 
            // xrTableCell120
            // 
            this.xrTableCell120.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel616,
            this.xrLabel615,
            this.xrLabel614,
            this.xrLabel613,
            this.xrLabel612});
            this.xrTableCell120.Multiline = true;
            this.xrTableCell120.Name = "xrTableCell120";
            this.xrTableCell120.Weight = 1.2179481291159824D;
            // 
            // xrLabel616
            // 
            this.xrLabel616.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel616.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel616.LocationFloat = new DevExpress.Utils.PointFloat(4.577637E-05F, 60F);
            this.xrLabel616.Multiline = true;
            this.xrLabel616.Name = "xrLabel616";
            this.xrLabel616.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel616.SizeF = new System.Drawing.SizeF(121.7948F, 14.99997F);
            this.xrLabel616.StylePriority.UseBorderDashStyle = false;
            this.xrLabel616.StylePriority.UseBorders = false;
            this.xrLabel616.StylePriority.UsePadding = false;
            // 
            // xrLabel615
            // 
            this.xrLabel615.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel615.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel615.LocationFloat = new DevExpress.Utils.PointFloat(4.577637E-05F, 45F);
            this.xrLabel615.Multiline = true;
            this.xrLabel615.Name = "xrLabel615";
            this.xrLabel615.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel615.SizeF = new System.Drawing.SizeF(121.7948F, 14.99997F);
            this.xrLabel615.StylePriority.UseBorderDashStyle = false;
            this.xrLabel615.StylePriority.UseBorders = false;
            this.xrLabel615.StylePriority.UsePadding = false;
            // 
            // xrLabel614
            // 
            this.xrLabel614.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel614.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel614.LocationFloat = new DevExpress.Utils.PointFloat(4.577637E-05F, 30F);
            this.xrLabel614.Multiline = true;
            this.xrLabel614.Name = "xrLabel614";
            this.xrLabel614.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel614.SizeF = new System.Drawing.SizeF(121.7948F, 14.99997F);
            this.xrLabel614.StylePriority.UseBorderDashStyle = false;
            this.xrLabel614.StylePriority.UseBorders = false;
            this.xrLabel614.StylePriority.UsePadding = false;
            // 
            // xrLabel613
            // 
            this.xrLabel613.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel613.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel613.LocationFloat = new DevExpress.Utils.PointFloat(4.577637E-05F, 15F);
            this.xrLabel613.Multiline = true;
            this.xrLabel613.Name = "xrLabel613";
            this.xrLabel613.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel613.SizeF = new System.Drawing.SizeF(121.7948F, 14.99997F);
            this.xrLabel613.StylePriority.UseBorderDashStyle = false;
            this.xrLabel613.StylePriority.UseBorders = false;
            this.xrLabel613.StylePriority.UsePadding = false;
            // 
            // xrLabel612
            // 
            this.xrLabel612.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel612.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel612.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel612.Multiline = true;
            this.xrLabel612.Name = "xrLabel612";
            this.xrLabel612.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel612.SizeF = new System.Drawing.SizeF(121.7948F, 14.99997F);
            this.xrLabel612.StylePriority.UseBorderDashStyle = false;
            this.xrLabel612.StylePriority.UseBorders = false;
            this.xrLabel612.StylePriority.UsePadding = false;
            // 
            // xrTable13
            // 
            this.xrTable13.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable13.LocationFloat = new DevExpress.Utils.PointFloat(0.2477786F, 480.8578F);
            this.xrTable13.Name = "xrTable13";
            this.xrTable13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable13.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow13});
            this.xrTable13.SizeF = new System.Drawing.SizeF(173F, 87.14224F);
            this.xrTable13.StylePriority.UseBorders = false;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell116,
            this.xrTableCell118});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Weight = 1D;
            // 
            // xrTableCell116
            // 
            this.xrTableCell116.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell116.Multiline = true;
            this.xrTableCell116.Name = "xrTableCell116";
            this.xrTableCell116.StylePriority.UseFont = false;
            this.xrTableCell116.StylePriority.UseTextAlignment = false;
            this.xrTableCell116.Text = "Thuốc";
            this.xrTableCell116.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell116.Weight = 0.51205179459007255D;
            // 
            // xrTableCell118
            // 
            this.xrTableCell118.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel606,
            this.xrLabel605,
            this.xrLabel604,
            this.xrLabel603,
            this.xrLabel602});
            this.xrTableCell118.Multiline = true;
            this.xrTableCell118.Name = "xrTableCell118";
            this.xrTableCell118.Weight = 1.2179481291159824D;
            // 
            // xrLabel606
            // 
            this.xrLabel606.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel606.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel606.LocationFloat = new DevExpress.Utils.PointFloat(4.577637E-05F, 59.99988F);
            this.xrLabel606.Multiline = true;
            this.xrLabel606.Name = "xrLabel606";
            this.xrLabel606.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel606.SizeF = new System.Drawing.SizeF(121.7948F, 14.99997F);
            this.xrLabel606.StylePriority.UseBorderDashStyle = false;
            this.xrLabel606.StylePriority.UseBorders = false;
            this.xrLabel606.StylePriority.UsePadding = false;
            // 
            // xrLabel605
            // 
            this.xrLabel605.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel605.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel605.LocationFloat = new DevExpress.Utils.PointFloat(4.577637E-05F, 44.99988F);
            this.xrLabel605.Multiline = true;
            this.xrLabel605.Name = "xrLabel605";
            this.xrLabel605.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel605.SizeF = new System.Drawing.SizeF(121.7948F, 14.99997F);
            this.xrLabel605.StylePriority.UseBorderDashStyle = false;
            this.xrLabel605.StylePriority.UseBorders = false;
            this.xrLabel605.StylePriority.UsePadding = false;
            // 
            // xrLabel604
            // 
            this.xrLabel604.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel604.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel604.LocationFloat = new DevExpress.Utils.PointFloat(4.577637E-05F, 29.99994F);
            this.xrLabel604.Multiline = true;
            this.xrLabel604.Name = "xrLabel604";
            this.xrLabel604.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel604.SizeF = new System.Drawing.SizeF(121.7948F, 14.99997F);
            this.xrLabel604.StylePriority.UseBorderDashStyle = false;
            this.xrLabel604.StylePriority.UseBorders = false;
            this.xrLabel604.StylePriority.UsePadding = false;
            // 
            // xrLabel603
            // 
            this.xrLabel603.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel603.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel603.LocationFloat = new DevExpress.Utils.PointFloat(4.577637E-05F, 14.99997F);
            this.xrLabel603.Multiline = true;
            this.xrLabel603.Name = "xrLabel603";
            this.xrLabel603.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel603.SizeF = new System.Drawing.SizeF(121.7948F, 14.99997F);
            this.xrLabel603.StylePriority.UseBorderDashStyle = false;
            this.xrLabel603.StylePriority.UseBorders = false;
            this.xrLabel603.StylePriority.UsePadding = false;
            // 
            // xrLabel602
            // 
            this.xrLabel602.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel602.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel602.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel602.Multiline = true;
            this.xrLabel602.Name = "xrLabel602";
            this.xrLabel602.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel602.SizeF = new System.Drawing.SizeF(121.7948F, 14.99997F);
            this.xrLabel602.StylePriority.UseBorderDashStyle = false;
            this.xrLabel602.StylePriority.UseBorders = false;
            this.xrLabel602.StylePriority.UsePadding = false;
            // 
            // xrTable12
            // 
            this.xrTable12.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable12.LocationFloat = new DevExpress.Utils.PointFloat(0.2477576F, 389.7178F);
            this.xrTable12.Name = "xrTable12";
            this.xrTable12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable12.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow12});
            this.xrTable12.SizeF = new System.Drawing.SizeF(173.0006F, 91.14F);
            this.xrTable12.StylePriority.UseBorders = false;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell115,
            this.xrTableCell117});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.Weight = 1D;
            // 
            // xrTableCell115
            // 
            this.xrTableCell115.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell115.Multiline = true;
            this.xrTableCell115.Name = "xrTableCell115";
            this.xrTableCell115.StylePriority.UseFont = false;
            this.xrTableCell115.StylePriority.UseTextAlignment = false;
            this.xrTableCell115.Text = "Hô Hấp";
            this.xrTableCell115.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell115.Weight = 0.5120520616188694D;
            // 
            // xrTableCell117
            // 
            this.xrTableCell117.Multiline = true;
            this.xrTableCell117.Name = "xrTableCell117";
            this.xrTableCell117.Text = "Máy\r\n\r\n\r\n\r\nMê";
            this.xrTableCell117.Weight = 1.2179540418964834D;
            // 
            // xrLabel334
            // 
            this.xrLabel334.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel334.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel334.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel334.LocationFloat = new DevExpress.Utils.PointFloat(5.057454E-05F, 374.2373F);
            this.xrLabel334.Multiline = true;
            this.xrLabel334.Name = "xrLabel334";
            this.xrLabel334.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel334.SizeF = new System.Drawing.SizeF(173.2478F, 15F);
            this.xrLabel334.StylePriority.UseBorderDashStyle = false;
            this.xrLabel334.StylePriority.UseBorders = false;
            this.xrLabel334.StylePriority.UseFont = false;
            this.xrLabel334.StylePriority.UsePadding = false;
            this.xrLabel334.StylePriority.UseTextAlignment = false;
            this.xrLabel334.Text = "Nhịp thở";
            this.xrLabel334.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel333
            // 
            this.xrLabel333.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel333.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel333.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel333.LocationFloat = new DevExpress.Utils.PointFloat(5.534291E-05F, 359.2373F);
            this.xrLabel333.Multiline = true;
            this.xrLabel333.Name = "xrLabel333";
            this.xrLabel333.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel333.SizeF = new System.Drawing.SizeF(173.2478F, 15F);
            this.xrLabel333.StylePriority.UseBorderDashStyle = false;
            this.xrLabel333.StylePriority.UseBorders = false;
            this.xrLabel333.StylePriority.UseFont = false;
            this.xrLabel333.StylePriority.UsePadding = false;
            this.xrLabel333.StylePriority.UseTextAlignment = false;
            this.xrLabel333.Text = "Bơm hơi ổ bụng";
            this.xrLabel333.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel332
            // 
            this.xrLabel332.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel332.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel332.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel332.LocationFloat = new DevExpress.Utils.PointFloat(5.534291E-05F, 344.2373F);
            this.xrLabel332.Multiline = true;
            this.xrLabel332.Name = "xrLabel332";
            this.xrLabel332.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel332.SizeF = new System.Drawing.SizeF(173.2478F, 15F);
            this.xrLabel332.StylePriority.UseBorderDashStyle = false;
            this.xrLabel332.StylePriority.UseBorders = false;
            this.xrLabel332.StylePriority.UseFont = false;
            this.xrLabel332.StylePriority.UsePadding = false;
            this.xrLabel332.StylePriority.UseTextAlignment = false;
            this.xrLabel332.Text = "Thay đổi tư thế";
            this.xrLabel332.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel331
            // 
            this.xrLabel331.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel331.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel331.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel331.LocationFloat = new DevExpress.Utils.PointFloat(5.534291E-05F, 329.2373F);
            this.xrLabel331.Multiline = true;
            this.xrLabel331.Name = "xrLabel331";
            this.xrLabel331.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel331.SizeF = new System.Drawing.SizeF(173.2478F, 15F);
            this.xrLabel331.StylePriority.UseBorderDashStyle = false;
            this.xrLabel331.StylePriority.UseBorders = false;
            this.xrLabel331.StylePriority.UseFont = false;
            this.xrLabel331.StylePriority.UsePadding = false;
            this.xrLabel331.StylePriority.UseTextAlignment = false;
            this.xrLabel331.Text = "ALĐMP / ALĐMPB /";
            this.xrLabel331.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel330
            // 
            this.xrLabel330.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel330.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel330.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel330.LocationFloat = new DevExpress.Utils.PointFloat(5.534291E-05F, 314.2373F);
            this.xrLabel330.Multiline = true;
            this.xrLabel330.Name = "xrLabel330";
            this.xrLabel330.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel330.SizeF = new System.Drawing.SizeF(173.2478F, 15F);
            this.xrLabel330.StylePriority.UseBorderDashStyle = false;
            this.xrLabel330.StylePriority.UseBorders = false;
            this.xrLabel330.StylePriority.UseFont = false;
            this.xrLabel330.StylePriority.UsePadding = false;
            this.xrLabel330.StylePriority.UseTextAlignment = false;
            this.xrLabel330.Text = "Nước tiểu";
            this.xrLabel330.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel325
            // 
            this.xrLabel325.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel325.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel325.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel325.LocationFloat = new DevExpress.Utils.PointFloat(5.534291E-05F, 299.2373F);
            this.xrLabel325.Multiline = true;
            this.xrLabel325.Name = "xrLabel325";
            this.xrLabel325.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel325.SizeF = new System.Drawing.SizeF(173.2478F, 15F);
            this.xrLabel325.StylePriority.UseBorderDashStyle = false;
            this.xrLabel325.StylePriority.UseBorders = false;
            this.xrLabel325.StylePriority.UseFont = false;
            this.xrLabel325.StylePriority.UsePadding = false;
            this.xrLabel325.StylePriority.UseTextAlignment = false;
            this.xrLabel325.Text = "Mất máu";
            this.xrLabel325.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel325.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrLabel325_BeforePrint);
            // 
            // xrLabel324
            // 
            this.xrLabel324.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel324.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel324.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel324.LocationFloat = new DevExpress.Utils.PointFloat(5.534291E-05F, 284.2373F);
            this.xrLabel324.Multiline = true;
            this.xrLabel324.Name = "xrLabel324";
            this.xrLabel324.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel324.SizeF = new System.Drawing.SizeF(173.2478F, 15F);
            this.xrLabel324.StylePriority.UseBorderDashStyle = false;
            this.xrLabel324.StylePriority.UseBorders = false;
            this.xrLabel324.StylePriority.UseFont = false;
            this.xrLabel324.StylePriority.UsePadding = false;
            this.xrLabel324.StylePriority.UseTextAlignment = false;
            this.xrLabel324.Text = "Trao đổi về nguy cơ mất";
            this.xrLabel324.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel324.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrLabel324_BeforePrint);
            // 
            // xrLabel323
            // 
            this.xrLabel323.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel323.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel323.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel323.LocationFloat = new DevExpress.Utils.PointFloat(0.2477722F, 269.2373F);
            this.xrLabel323.Multiline = true;
            this.xrLabel323.Name = "xrLabel323";
            this.xrLabel323.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel323.SizeF = new System.Drawing.SizeF(173F, 15F);
            this.xrLabel323.StylePriority.UseBorderDashStyle = false;
            this.xrLabel323.StylePriority.UseBorders = false;
            this.xrLabel323.StylePriority.UseFont = false;
            this.xrLabel323.StylePriority.UsePadding = false;
            this.xrLabel323.StylePriority.UseTextAlignment = false;
            this.xrLabel323.Text = "Nhiệt độ";
            this.xrLabel323.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel318
            // 
            this.xrLabel318.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel318.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel318.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel318.LocationFloat = new DevExpress.Utils.PointFloat(0F, 254.2373F);
            this.xrLabel318.Multiline = true;
            this.xrLabel318.Name = "xrLabel318";
            this.xrLabel318.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel318.SizeF = new System.Drawing.SizeF(173.2478F, 15F);
            this.xrLabel318.StylePriority.UseBorderDashStyle = false;
            this.xrLabel318.StylePriority.UseBorders = false;
            this.xrLabel318.StylePriority.UseFont = false;
            this.xrLabel318.StylePriority.UsePadding = false;
            this.xrLabel318.StylePriority.UseTextAlignment = false;
            this.xrLabel318.Text = "Đặt nội khí quản - Thành";
            this.xrLabel318.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel47
            // 
            this.xrLabel47.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrLabel47.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel47.LocationFloat = new DevExpress.Utils.PointFloat(7.539988E-06F, 1.237267F);
            this.xrLabel47.Multiline = true;
            this.xrLabel47.Name = "xrLabel47";
            this.xrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel47.SizeF = new System.Drawing.SizeF(173.2478F, 253F);
            this.xrLabel47.StylePriority.UseBorders = false;
            this.xrLabel47.StylePriority.UseFont = false;
            this.xrLabel47.Text = "Đánh giá trước mổ\r\n- ASA: 1 2 3 4 5\r\n- Dạ dày đầy / cấp cứu\r\n- Mallampati: 1 2 3 " +
    "4\r\n- Dị ứng:\r\n- Tiền sử / Thuốc dùng liên quan GMSH\r\n\r\n\r\nBất thường lâm sàng / c" +
    "ận lâm sàng liên quan GMSH";
            // 
            // xrLabel629
            // 
            this.xrLabel629.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrLabel629.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel629.LocationFloat = new DevExpress.Utils.PointFloat(0.2477786F, 659.5F);
            this.xrLabel629.Multiline = true;
            this.xrLabel629.Name = "xrLabel629";
            this.xrLabel629.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel629.SizeF = new System.Drawing.SizeF(51.20551F, 86.85913F);
            this.xrLabel629.StylePriority.UseBorders = false;
            this.xrLabel629.StylePriority.UseFont = false;
            this.xrLabel629.StylePriority.UsePadding = false;
            this.xrLabel629.StylePriority.UseTextAlignment = false;
            this.xrLabel629.Text = "Quan sát";
            this.xrLabel629.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel7,
            this.xrPanel6,
            this.xrPanel5,
            this.xrLabel336,
            this.xrLabel335,
            this.xrLabel328,
            this.xrLabel327,
            this.xrLabel326,
            this.xrLabel322,
            this.xrLabel321,
            this.xrLabel320,
            this.xrPanel3,
            this.xrLabel319});
            this.xrTableCell2.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.Weight = 0.56995490524608772D;
            // 
            // xrPanel7
            // 
            this.xrPanel7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrPanel7.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel621,
            this.xrLabel620,
            this.xrLabel619,
            this.xrLabel618,
            this.xrLabel617});
            this.xrPanel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 551.8F);
            this.xrPanel7.Name = "xrPanel7";
            this.xrPanel7.SizeF = new System.Drawing.SizeF(103.5466F, 91.5F);
            this.xrPanel7.StylePriority.UseBorders = false;
            // 
            // xrLabel621
            // 
            this.xrLabel621.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel621.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel621.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99994F);
            this.xrLabel621.Multiline = true;
            this.xrLabel621.Name = "xrLabel621";
            this.xrLabel621.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel621.SizeF = new System.Drawing.SizeF(103.5471F, 14.99997F);
            this.xrLabel621.StylePriority.UseBorderDashStyle = false;
            this.xrLabel621.StylePriority.UseBorders = false;
            this.xrLabel621.StylePriority.UsePadding = false;
            // 
            // xrLabel620
            // 
            this.xrLabel620.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel620.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel620.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99994F);
            this.xrLabel620.Multiline = true;
            this.xrLabel620.Name = "xrLabel620";
            this.xrLabel620.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel620.SizeF = new System.Drawing.SizeF(103.5471F, 14.99997F);
            this.xrLabel620.StylePriority.UseBorderDashStyle = false;
            this.xrLabel620.StylePriority.UseBorders = false;
            this.xrLabel620.StylePriority.UsePadding = false;
            // 
            // xrLabel619
            // 
            this.xrLabel619.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel619.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel619.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel619.Multiline = true;
            this.xrLabel619.Name = "xrLabel619";
            this.xrLabel619.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel619.SizeF = new System.Drawing.SizeF(103.5471F, 14.99997F);
            this.xrLabel619.StylePriority.UseBorderDashStyle = false;
            this.xrLabel619.StylePriority.UseBorders = false;
            this.xrLabel619.StylePriority.UsePadding = false;
            // 
            // xrLabel618
            // 
            this.xrLabel618.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel618.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel618.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99994F);
            this.xrLabel618.Multiline = true;
            this.xrLabel618.Name = "xrLabel618";
            this.xrLabel618.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel618.SizeF = new System.Drawing.SizeF(103.5471F, 14.99997F);
            this.xrLabel618.StylePriority.UseBorderDashStyle = false;
            this.xrLabel618.StylePriority.UseBorders = false;
            this.xrLabel618.StylePriority.UsePadding = false;
            // 
            // xrLabel617
            // 
            this.xrLabel617.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel617.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel617.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel617.Multiline = true;
            this.xrLabel617.Name = "xrLabel617";
            this.xrLabel617.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel617.SizeF = new System.Drawing.SizeF(103.5471F, 14.99997F);
            this.xrLabel617.StylePriority.UseBorderDashStyle = false;
            this.xrLabel617.StylePriority.UseBorders = false;
            this.xrLabel617.StylePriority.UsePadding = false;
            // 
            // xrPanel6
            // 
            this.xrPanel6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrPanel6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel611,
            this.xrLabel610,
            this.xrLabel609,
            this.xrLabel608,
            this.xrLabel607});
            this.xrPanel6.LocationFloat = new DevExpress.Utils.PointFloat(0.0006103516F, 461.8F);
            this.xrPanel6.Name = "xrPanel6";
            this.xrPanel6.SizeF = new System.Drawing.SizeF(103.5466F, 90F);
            this.xrPanel6.StylePriority.UseBorders = false;
            // 
            // xrLabel611
            // 
            this.xrLabel611.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel611.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel611.LocationFloat = new DevExpress.Utils.PointFloat(0F, 62F);
            this.xrLabel611.Multiline = true;
            this.xrLabel611.Name = "xrLabel611";
            this.xrLabel611.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel611.SizeF = new System.Drawing.SizeF(103.5471F, 14.99997F);
            this.xrLabel611.StylePriority.UseBorderDashStyle = false;
            this.xrLabel611.StylePriority.UseBorders = false;
            this.xrLabel611.StylePriority.UsePadding = false;
            // 
            // xrLabel610
            // 
            this.xrLabel610.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel610.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel610.LocationFloat = new DevExpress.Utils.PointFloat(0F, 47.00003F);
            this.xrLabel610.Multiline = true;
            this.xrLabel610.Name = "xrLabel610";
            this.xrLabel610.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel610.SizeF = new System.Drawing.SizeF(103.5471F, 14.99997F);
            this.xrLabel610.StylePriority.UseBorderDashStyle = false;
            this.xrLabel610.StylePriority.UseBorders = false;
            this.xrLabel610.StylePriority.UsePadding = false;
            // 
            // xrLabel609
            // 
            this.xrLabel609.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel609.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel609.LocationFloat = new DevExpress.Utils.PointFloat(0F, 32.00006F);
            this.xrLabel609.Multiline = true;
            this.xrLabel609.Name = "xrLabel609";
            this.xrLabel609.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel609.SizeF = new System.Drawing.SizeF(103.5471F, 14.99997F);
            this.xrLabel609.StylePriority.UseBorderDashStyle = false;
            this.xrLabel609.StylePriority.UseBorders = false;
            this.xrLabel609.StylePriority.UsePadding = false;
            // 
            // xrLabel608
            // 
            this.xrLabel608.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel608.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel608.LocationFloat = new DevExpress.Utils.PointFloat(0F, 17.00009F);
            this.xrLabel608.Multiline = true;
            this.xrLabel608.Name = "xrLabel608";
            this.xrLabel608.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel608.SizeF = new System.Drawing.SizeF(103.5471F, 14.99997F);
            this.xrLabel608.StylePriority.UseBorderDashStyle = false;
            this.xrLabel608.StylePriority.UseBorders = false;
            this.xrLabel608.StylePriority.UsePadding = false;
            // 
            // xrLabel607
            // 
            this.xrLabel607.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel607.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel607.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2.000122F);
            this.xrLabel607.Multiline = true;
            this.xrLabel607.Name = "xrLabel607";
            this.xrLabel607.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel607.SizeF = new System.Drawing.SizeF(103.5471F, 14.99997F);
            this.xrLabel607.StylePriority.UseBorderDashStyle = false;
            this.xrLabel607.StylePriority.UseBorders = false;
            this.xrLabel607.StylePriority.UsePadding = false;
            // 
            // xrPanel5
            // 
            this.xrPanel5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrPanel5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel627,
            this.xrLabel626,
            this.xrLabel625,
            this.xrLabel624,
            this.xrLabel623,
            this.xrLabel622,
            this.xrLine15,
            this.xrLine14,
            this.xrLine13});
            this.xrPanel5.LocationFloat = new DevExpress.Utils.PointFloat(0.0003356934F, 373.4143F);
            this.xrPanel5.Name = "xrPanel5";
            this.xrPanel5.SizeF = new System.Drawing.SizeF(103.5466F, 90.38577F);
            this.xrPanel5.StylePriority.UseBorders = false;
            // 
            // xrLabel627
            // 
            this.xrLabel627.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel627.Font = new DevExpress.Drawing.DXFont("Times New Roman", 6F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel627.LocationFloat = new DevExpress.Utils.PointFloat(29.62091F, 74.26071F);
            this.xrLabel627.Multiline = true;
            this.xrLabel627.Name = "xrLabel627";
            this.xrLabel627.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel627.SizeF = new System.Drawing.SizeF(73.92532F, 14.125F);
            this.xrLabel627.StylePriority.UseBorders = false;
            this.xrLabel627.StylePriority.UseFont = false;
            this.xrLabel627.StylePriority.UseTextAlignment = false;
            this.xrLabel627.Text = "%Hal/ISO/N2O";
            this.xrLabel627.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // xrLabel626
            // 
            this.xrLabel626.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel626.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.51093F);
            this.xrLabel626.Multiline = true;
            this.xrLabel626.Name = "xrLabel626";
            this.xrLabel626.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel626.SizeF = new System.Drawing.SizeF(49.68288F, 14.125F);
            this.xrLabel626.StylePriority.UseBorders = false;
            this.xrLabel626.StylePriority.UseTextAlignment = false;
            this.xrLabel626.Text = "FiO2";
            this.xrLabel626.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel625
            // 
            this.xrLabel625.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel625.LocationFloat = new DevExpress.Utils.PointFloat(53.86455F, 44.51096F);
            this.xrLabel625.Multiline = true;
            this.xrLabel625.Name = "xrLabel625";
            this.xrLabel625.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel625.SizeF = new System.Drawing.SizeF(49.68288F, 14.125F);
            this.xrLabel625.StylePriority.UseBorders = false;
            this.xrLabel625.StylePriority.UseTextAlignment = false;
            this.xrLabel625.Text = "SpO2";
            this.xrLabel625.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel624
            // 
            this.xrLabel624.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel624.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.51099F);
            this.xrLabel624.Multiline = true;
            this.xrLabel624.Name = "xrLabel624";
            this.xrLabel624.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel624.SizeF = new System.Drawing.SizeF(49.68288F, 14.125F);
            this.xrLabel624.StylePriority.UseBorders = false;
            this.xrLabel624.StylePriority.UseTextAlignment = false;
            this.xrLabel624.Text = "Áp lực";
            this.xrLabel624.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel623
            // 
            this.xrLabel623.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel623.LocationFloat = new DevExpress.Utils.PointFloat(53.86455F, 14.51102F);
            this.xrLabel623.Multiline = true;
            this.xrLabel623.Name = "xrLabel623";
            this.xrLabel623.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel623.SizeF = new System.Drawing.SizeF(49.68288F, 14.125F);
            this.xrLabel623.StylePriority.UseBorders = false;
            this.xrLabel623.StylePriority.UseTextAlignment = false;
            this.xrLabel623.Text = "FeCO2";
            this.xrLabel623.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel622
            // 
            this.xrLabel622.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel622.LocationFloat = new DevExpress.Utils.PointFloat(1.525879E-05F, 0.3860168F);
            this.xrLabel622.Multiline = true;
            this.xrLabel622.Name = "xrLabel622";
            this.xrLabel622.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel622.SizeF = new System.Drawing.SizeF(49.68288F, 14.125F);
            this.xrLabel622.StylePriority.UseBorders = false;
            this.xrLabel622.StylePriority.UseTextAlignment = false;
            this.xrLabel622.Text = "TTLT";
            this.xrLabel622.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLine15
            // 
            this.xrLine15.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLine15.LineDirection = DevExpress.XtraReports.UI.LineDirection.Slant;
            this.xrLine15.LocationFloat = new DevExpress.Utils.PointFloat(0F, 60.38586F);
            this.xrLine15.Name = "xrLine15";
            this.xrLine15.SizeF = new System.Drawing.SizeF(103.5468F, 29.99994F);
            this.xrLine15.StylePriority.UseBorders = false;
            // 
            // xrLine14
            // 
            this.xrLine14.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLine14.LineDirection = DevExpress.XtraReports.UI.LineDirection.Slant;
            this.xrLine14.LocationFloat = new DevExpress.Utils.PointFloat(0F, 30.38593F);
            this.xrLine14.Name = "xrLine14";
            this.xrLine14.SizeF = new System.Drawing.SizeF(103.5468F, 29.99994F);
            this.xrLine14.StylePriority.UseBorders = false;
            // 
            // xrLine13
            // 
            this.xrLine13.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLine13.LineDirection = DevExpress.XtraReports.UI.LineDirection.Slant;
            this.xrLine13.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.3859863F);
            this.xrLine13.Name = "xrLine13";
            this.xrLine13.SizeF = new System.Drawing.SizeF(103.5468F, 29.99994F);
            this.xrLine13.StylePriority.UseBorders = false;
            // 
            // xrLabel336
            // 
            this.xrLabel336.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel336.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel336.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel336.LocationFloat = new DevExpress.Utils.PointFloat(6.103516E-05F, 357.857F);
            this.xrLabel336.Multiline = true;
            this.xrLabel336.Name = "xrLabel336";
            this.xrLabel336.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel336.SizeF = new System.Drawing.SizeF(103.5468F, 15F);
            this.xrLabel336.StylePriority.UseBorderDashStyle = false;
            this.xrLabel336.StylePriority.UseBorders = false;
            this.xrLabel336.StylePriority.UseFont = false;
            this.xrLabel336.StylePriority.UsePadding = false;
            // 
            // xrLabel335
            // 
            this.xrLabel335.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel335.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel335.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel335.LocationFloat = new DevExpress.Utils.PointFloat(6.103516E-05F, 342.857F);
            this.xrLabel335.Multiline = true;
            this.xrLabel335.Name = "xrLabel335";
            this.xrLabel335.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel335.SizeF = new System.Drawing.SizeF(103.5468F, 15F);
            this.xrLabel335.StylePriority.UseBorderDashStyle = false;
            this.xrLabel335.StylePriority.UseBorders = false;
            this.xrLabel335.StylePriority.UseFont = false;
            this.xrLabel335.StylePriority.UsePadding = false;
            this.xrLabel335.StylePriority.UseTextAlignment = false;
            this.xrLabel335.Text = "- Có (x)";
            this.xrLabel335.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel328
            // 
            this.xrLabel328.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel328.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel328.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel328.LocationFloat = new DevExpress.Utils.PointFloat(6.103516E-05F, 327.4711F);
            this.xrLabel328.Multiline = true;
            this.xrLabel328.Name = "xrLabel328";
            this.xrLabel328.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel328.SizeF = new System.Drawing.SizeF(103.5468F, 15F);
            this.xrLabel328.StylePriority.UseBorderDashStyle = false;
            this.xrLabel328.StylePriority.UseBorders = false;
            this.xrLabel328.StylePriority.UseFont = false;
            this.xrLabel328.StylePriority.UsePadding = false;
            this.xrLabel328.StylePriority.UseTextAlignment = false;
            this.xrLabel328.Text = "- Có (x)";
            this.xrLabel328.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel327
            // 
            this.xrLabel327.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel327.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel327.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel327.LocationFloat = new DevExpress.Utils.PointFloat(6.103516E-05F, 312.4711F);
            this.xrLabel327.Multiline = true;
            this.xrLabel327.Name = "xrLabel327";
            this.xrLabel327.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel327.SizeF = new System.Drawing.SizeF(103.5468F, 15F);
            this.xrLabel327.StylePriority.UseBorderDashStyle = false;
            this.xrLabel327.StylePriority.UseBorders = false;
            this.xrLabel327.StylePriority.UseFont = false;
            this.xrLabel327.StylePriority.UsePadding = false;
            this.xrLabel327.StylePriority.UseTextAlignment = false;
            this.xrLabel327.Text = "ALTMTƯ";
            this.xrLabel327.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel326
            // 
            this.xrLabel326.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel326.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel326.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel326.LocationFloat = new DevExpress.Utils.PointFloat(6.103516E-05F, 297.4711F);
            this.xrLabel326.Multiline = true;
            this.xrLabel326.Name = "xrLabel326";
            this.xrLabel326.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel326.SizeF = new System.Drawing.SizeF(103.5468F, 15F);
            this.xrLabel326.StylePriority.UseBorderDashStyle = false;
            this.xrLabel326.StylePriority.UseBorders = false;
            this.xrLabel326.StylePriority.UseFont = false;
            this.xrLabel326.StylePriority.UsePadding = false;
            this.xrLabel326.StylePriority.UseTextAlignment = false;
            this.xrLabel326.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel322
            // 
            this.xrLabel322.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel322.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel322.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel322.LocationFloat = new DevExpress.Utils.PointFloat(6.103516E-05F, 282.4711F);
            this.xrLabel322.Multiline = true;
            this.xrLabel322.Name = "xrLabel322";
            this.xrLabel322.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel322.SizeF = new System.Drawing.SizeF(103.5468F, 15F);
            this.xrLabel322.StylePriority.UseBorderDashStyle = false;
            this.xrLabel322.StylePriority.UseBorders = false;
            this.xrLabel322.StylePriority.UseFont = false;
            this.xrLabel322.StylePriority.UsePadding = false;
            this.xrLabel322.StylePriority.UseTextAlignment = false;
            this.xrLabel322.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel321
            // 
            this.xrLabel321.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel321.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel321.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel321.LocationFloat = new DevExpress.Utils.PointFloat(0F, 267.4713F);
            this.xrLabel321.Multiline = true;
            this.xrLabel321.Name = "xrLabel321";
            this.xrLabel321.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel321.SizeF = new System.Drawing.SizeF(103.5468F, 13F);
            this.xrLabel321.StylePriority.UseBorderDashStyle = false;
            this.xrLabel321.StylePriority.UseBorders = false;
            this.xrLabel321.StylePriority.UseFont = false;
            this.xrLabel321.StylePriority.UsePadding = false;
            this.xrLabel321.StylePriority.UseTextAlignment = false;
            this.xrLabel321.Text = "máu -Có (x)";
            this.xrLabel321.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel320
            // 
            this.xrLabel320.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel320.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel320.LocationFloat = new DevExpress.Utils.PointFloat(0F, 252.4713F);
            this.xrLabel320.Multiline = true;
            this.xrLabel320.Name = "xrLabel320";
            this.xrLabel320.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel320.SizeF = new System.Drawing.SizeF(103.5468F, 15F);
            this.xrLabel320.StylePriority.UseBorderDashStyle = false;
            this.xrLabel320.StylePriority.UseBorders = false;
            this.xrLabel320.StylePriority.UsePadding = false;
            this.xrLabel320.StylePriority.UseTextAlignment = false;
            this.xrLabel320.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrPanel3
            // 
            this.xrPanel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPanel3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel48,
            this.xrLabel49,
            this.xrLabel50,
            this.xrLabel51,
            this.xrLabel52,
            this.xrLabel53,
            this.xrLabel54});
            this.xrPanel3.LocationFloat = new DevExpress.Utils.PointFloat(1.525879E-05F, 1.237259F);
            this.xrPanel3.Name = "xrPanel3";
            this.xrPanel3.SizeF = new System.Drawing.SizeF(103.5468F, 238.234F);
            this.xrPanel3.StylePriority.UseBorders = false;
            // 
            // xrLabel48
            // 
            this.xrLabel48.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel48.LocationFloat = new DevExpress.Utils.PointFloat(10.00005F, 1.23452F);
            this.xrLabel48.Multiline = true;
            this.xrLabel48.Name = "xrLabel48";
            this.xrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel48.SizeF = new System.Drawing.SizeF(83.54665F, 14.5062F);
            this.xrLabel48.StylePriority.UseBorders = false;
            this.xrLabel48.StylePriority.UseTextAlignment = false;
            this.xrLabel48.Text = "HA";
            this.xrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel49
            // 
            this.xrLabel49.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel49.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Underline);
            this.xrLabel49.LocationFloat = new DevExpress.Utils.PointFloat(10.00003F, 16.60485F);
            this.xrLabel49.Multiline = true;
            this.xrLabel49.Name = "xrLabel49";
            this.xrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel49.SizeF = new System.Drawing.SizeF(83.54666F, 14.50618F);
            this.xrLabel49.StylePriority.UseBorders = false;
            this.xrLabel49.StylePriority.UseFont = false;
            this.xrLabel49.StylePriority.UseTextAlignment = false;
            this.xrLabel49.Text = "v  Mx  v";
            this.xrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel50
            // 
            this.xrLabel50.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel50.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel50.LocationFloat = new DevExpress.Utils.PointFloat(10.00003F, 31.11103F);
            this.xrLabel50.Multiline = true;
            this.xrLabel50.Name = "xrLabel50";
            this.xrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel50.SizeF = new System.Drawing.SizeF(83.54669F, 14.50617F);
            this.xrLabel50.StylePriority.UseBorders = false;
            this.xrLabel50.StylePriority.UseFont = false;
            this.xrLabel50.StylePriority.UseTextAlignment = false;
            this.xrLabel50.Text = "^  Mn  ^";
            this.xrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel51
            // 
            this.xrLabel51.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel51.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Underline);
            this.xrLabel51.LocationFloat = new DevExpress.Utils.PointFloat(10.00005F, 55F);
            this.xrLabel51.Multiline = true;
            this.xrLabel51.Name = "xrLabel51";
            this.xrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel51.SizeF = new System.Drawing.SizeF(83.54666F, 14.50617F);
            this.xrLabel51.StylePriority.UseBorders = false;
            this.xrLabel51.StylePriority.UseFont = false;
            this.xrLabel51.StylePriority.UseTextAlignment = false;
            this.xrLabel51.Text = "v          v";
            this.xrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel52
            // 
            this.xrLabel52.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel52.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel52.LocationFloat = new DevExpress.Utils.PointFloat(10.00011F, 69.50617F);
            this.xrLabel52.Multiline = true;
            this.xrLabel52.Name = "xrLabel52";
            this.xrLabel52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel52.SizeF = new System.Drawing.SizeF(83.54677F, 14.50617F);
            this.xrLabel52.StylePriority.UseBorders = false;
            this.xrLabel52.StylePriority.UseFont = false;
            this.xrLabel52.StylePriority.UseTextAlignment = false;
            this.xrLabel52.Text = "50";
            this.xrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel53
            // 
            this.xrLabel53.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel53.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel53.LocationFloat = new DevExpress.Utils.PointFloat(10.00011F, 134.7331F);
            this.xrLabel53.Multiline = true;
            this.xrLabel53.Name = "xrLabel53";
            this.xrLabel53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel53.SizeF = new System.Drawing.SizeF(83.54677F, 14.50618F);
            this.xrLabel53.StylePriority.UseBorders = false;
            this.xrLabel53.StylePriority.UseFont = false;
            this.xrLabel53.StylePriority.UseTextAlignment = false;
            this.xrLabel53.Text = "100";
            this.xrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel54
            // 
            this.xrLabel54.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel54.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel54.LocationFloat = new DevExpress.Utils.PointFloat(1.525879E-05F, 221.116F);
            this.xrLabel54.Multiline = true;
            this.xrLabel54.Name = "xrLabel54";
            this.xrLabel54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel54.SizeF = new System.Drawing.SizeF(103.5466F, 17.11795F);
            this.xrLabel54.StylePriority.UseBorders = false;
            this.xrLabel54.StylePriority.UseFont = false;
            this.xrLabel54.StylePriority.UseTextAlignment = false;
            this.xrLabel54.Text = "50";
            this.xrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel319
            // 
            this.xrLabel319.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel319.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel319.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel319.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 239.4713F);
            this.xrLabel319.Multiline = true;
            this.xrLabel319.Name = "xrLabel319";
            this.xrLabel319.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel319.SizeF = new System.Drawing.SizeF(103.5468F, 13F);
            this.xrLabel319.StylePriority.UseBorderDashStyle = false;
            this.xrLabel319.StylePriority.UseBorders = false;
            this.xrLabel319.StylePriority.UseFont = false;
            this.xrLabel319.StylePriority.UsePadding = false;
            this.xrLabel319.StylePriority.UseTextAlignment = false;
            this.xrLabel319.Text = "công (x)";
            this.xrLabel319.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable11,
            this.xrTable10,
            this.xrTable9,
            this.xrTable8,
            this.xrTable7,
            this.xrTable6,
            this.xrTable5,
            this.xrTable4,
            this.xrTable3,
            this.xrTable2});
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Weight = 2.0477157274284972D;
            // 
            // xrTable11
            // 
            this.xrTable11.LocationFloat = new DevExpress.Utils.PointFloat(0.0003356934F, 568.7654F);
            this.xrTable11.Name = "xrTable11";
            this.xrTable11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable11.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow11});
            this.xrTable11.SizeF = new System.Drawing.SizeF(372.019F, 90.38583F);
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell103,
            this.xrTableCell104,
            this.xrTableCell105,
            this.xrTableCell106,
            this.xrTableCell107,
            this.xrTableCell108,
            this.xrTableCell109,
            this.xrTableCell110,
            this.xrTableCell111,
            this.xrTableCell112,
            this.xrTableCell113,
            this.xrTableCell114});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Weight = 1D;
            // 
            // xrTableCell103
            // 
            this.xrTableCell103.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell103.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel529,
            this.xrLabel530,
            this.xrLabel531,
            this.xrLabel532,
            this.xrLabel533,
            this.xrLabel534});
            this.xrTableCell103.Multiline = true;
            this.xrTableCell103.Name = "xrTableCell103";
            this.xrTableCell103.StylePriority.UseBorders = false;
            this.xrTableCell103.Weight = 0.20290247599283853D;
            // 
            // xrLabel529
            // 
            this.xrLabel529.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel529.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel529.Multiline = true;
            this.xrLabel529.Name = "xrLabel529";
            this.xrLabel529.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel529.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel529.StylePriority.UseBorders = false;
            this.xrLabel529.StylePriority.UsePadding = false;
            // 
            // xrLabel530
            // 
            this.xrLabel530.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel530.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel530.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel530.Multiline = true;
            this.xrLabel530.Name = "xrLabel530";
            this.xrLabel530.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel530.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel530.StylePriority.UseBorderDashStyle = false;
            this.xrLabel530.StylePriority.UseBorders = false;
            this.xrLabel530.StylePriority.UsePadding = false;
            // 
            // xrLabel531
            // 
            this.xrLabel531.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel531.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel531.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel531.Multiline = true;
            this.xrLabel531.Name = "xrLabel531";
            this.xrLabel531.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel531.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel531.StylePriority.UseBorderDashStyle = false;
            this.xrLabel531.StylePriority.UseBorders = false;
            this.xrLabel531.StylePriority.UsePadding = false;
            // 
            // xrLabel532
            // 
            this.xrLabel532.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel532.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel532.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel532.Multiline = true;
            this.xrLabel532.Name = "xrLabel532";
            this.xrLabel532.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel532.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel532.StylePriority.UseBorderDashStyle = false;
            this.xrLabel532.StylePriority.UseBorders = false;
            this.xrLabel532.StylePriority.UsePadding = false;
            // 
            // xrLabel533
            // 
            this.xrLabel533.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel533.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel533.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel533.Multiline = true;
            this.xrLabel533.Name = "xrLabel533";
            this.xrLabel533.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel533.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel533.StylePriority.UseBorderDashStyle = false;
            this.xrLabel533.StylePriority.UseBorders = false;
            this.xrLabel533.StylePriority.UsePadding = false;
            // 
            // xrLabel534
            // 
            this.xrLabel534.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel534.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel534.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel534.Multiline = true;
            this.xrLabel534.Name = "xrLabel534";
            this.xrLabel534.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel534.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel534.StylePriority.UseBorderDashStyle = false;
            this.xrLabel534.StylePriority.UseBorders = false;
            this.xrLabel534.StylePriority.UsePadding = false;
            // 
            // xrTableCell104
            // 
            this.xrTableCell104.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell104.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel535,
            this.xrLabel536,
            this.xrLabel537,
            this.xrLabel538,
            this.xrLabel539,
            this.xrLabel540});
            this.xrTableCell104.Multiline = true;
            this.xrTableCell104.Name = "xrTableCell104";
            this.xrTableCell104.StylePriority.UseBorders = false;
            this.xrTableCell104.Weight = 0.20290247599283853D;
            // 
            // xrLabel535
            // 
            this.xrLabel535.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel535.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel535.Multiline = true;
            this.xrLabel535.Name = "xrLabel535";
            this.xrLabel535.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel535.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel535.StylePriority.UseBorders = false;
            this.xrLabel535.StylePriority.UsePadding = false;
            // 
            // xrLabel536
            // 
            this.xrLabel536.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel536.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel536.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel536.Multiline = true;
            this.xrLabel536.Name = "xrLabel536";
            this.xrLabel536.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel536.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel536.StylePriority.UseBorderDashStyle = false;
            this.xrLabel536.StylePriority.UseBorders = false;
            this.xrLabel536.StylePriority.UsePadding = false;
            // 
            // xrLabel537
            // 
            this.xrLabel537.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel537.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel537.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel537.Multiline = true;
            this.xrLabel537.Name = "xrLabel537";
            this.xrLabel537.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel537.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel537.StylePriority.UseBorderDashStyle = false;
            this.xrLabel537.StylePriority.UseBorders = false;
            this.xrLabel537.StylePriority.UsePadding = false;
            // 
            // xrLabel538
            // 
            this.xrLabel538.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel538.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel538.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel538.Multiline = true;
            this.xrLabel538.Name = "xrLabel538";
            this.xrLabel538.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel538.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel538.StylePriority.UseBorderDashStyle = false;
            this.xrLabel538.StylePriority.UseBorders = false;
            this.xrLabel538.StylePriority.UsePadding = false;
            // 
            // xrLabel539
            // 
            this.xrLabel539.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel539.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel539.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel539.Multiline = true;
            this.xrLabel539.Name = "xrLabel539";
            this.xrLabel539.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel539.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel539.StylePriority.UseBorderDashStyle = false;
            this.xrLabel539.StylePriority.UseBorders = false;
            this.xrLabel539.StylePriority.UsePadding = false;
            // 
            // xrLabel540
            // 
            this.xrLabel540.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel540.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel540.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel540.Multiline = true;
            this.xrLabel540.Name = "xrLabel540";
            this.xrLabel540.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel540.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel540.StylePriority.UseBorderDashStyle = false;
            this.xrLabel540.StylePriority.UseBorders = false;
            this.xrLabel540.StylePriority.UsePadding = false;
            // 
            // xrTableCell105
            // 
            this.xrTableCell105.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell105.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel541,
            this.xrLabel542,
            this.xrLabel543,
            this.xrLabel544,
            this.xrLabel545,
            this.xrLabel546});
            this.xrTableCell105.Multiline = true;
            this.xrTableCell105.Name = "xrTableCell105";
            this.xrTableCell105.StylePriority.UseBorders = false;
            this.xrTableCell105.Weight = 0.20290247599283853D;
            // 
            // xrLabel541
            // 
            this.xrLabel541.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel541.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel541.Multiline = true;
            this.xrLabel541.Name = "xrLabel541";
            this.xrLabel541.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel541.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel541.StylePriority.UseBorders = false;
            this.xrLabel541.StylePriority.UsePadding = false;
            // 
            // xrLabel542
            // 
            this.xrLabel542.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel542.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel542.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel542.Multiline = true;
            this.xrLabel542.Name = "xrLabel542";
            this.xrLabel542.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel542.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel542.StylePriority.UseBorderDashStyle = false;
            this.xrLabel542.StylePriority.UseBorders = false;
            this.xrLabel542.StylePriority.UsePadding = false;
            // 
            // xrLabel543
            // 
            this.xrLabel543.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel543.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel543.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel543.Multiline = true;
            this.xrLabel543.Name = "xrLabel543";
            this.xrLabel543.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel543.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel543.StylePriority.UseBorderDashStyle = false;
            this.xrLabel543.StylePriority.UseBorders = false;
            this.xrLabel543.StylePriority.UsePadding = false;
            // 
            // xrLabel544
            // 
            this.xrLabel544.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel544.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel544.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel544.Multiline = true;
            this.xrLabel544.Name = "xrLabel544";
            this.xrLabel544.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel544.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel544.StylePriority.UseBorderDashStyle = false;
            this.xrLabel544.StylePriority.UseBorders = false;
            this.xrLabel544.StylePriority.UsePadding = false;
            // 
            // xrLabel545
            // 
            this.xrLabel545.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel545.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel545.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel545.Multiline = true;
            this.xrLabel545.Name = "xrLabel545";
            this.xrLabel545.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel545.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel545.StylePriority.UseBorderDashStyle = false;
            this.xrLabel545.StylePriority.UseBorders = false;
            this.xrLabel545.StylePriority.UsePadding = false;
            // 
            // xrLabel546
            // 
            this.xrLabel546.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel546.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel546.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel546.Multiline = true;
            this.xrLabel546.Name = "xrLabel546";
            this.xrLabel546.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel546.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel546.StylePriority.UseBorderDashStyle = false;
            this.xrLabel546.StylePriority.UseBorders = false;
            this.xrLabel546.StylePriority.UsePadding = false;
            // 
            // xrTableCell106
            // 
            this.xrTableCell106.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell106.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel547,
            this.xrLabel548,
            this.xrLabel549,
            this.xrLabel550,
            this.xrLabel551,
            this.xrLabel552});
            this.xrTableCell106.Multiline = true;
            this.xrTableCell106.Name = "xrTableCell106";
            this.xrTableCell106.StylePriority.UseBorders = false;
            this.xrTableCell106.Weight = 0.20290247599283853D;
            // 
            // xrLabel547
            // 
            this.xrLabel547.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel547.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel547.Multiline = true;
            this.xrLabel547.Name = "xrLabel547";
            this.xrLabel547.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel547.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel547.StylePriority.UseBorders = false;
            this.xrLabel547.StylePriority.UsePadding = false;
            // 
            // xrLabel548
            // 
            this.xrLabel548.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel548.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel548.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel548.Multiline = true;
            this.xrLabel548.Name = "xrLabel548";
            this.xrLabel548.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel548.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel548.StylePriority.UseBorderDashStyle = false;
            this.xrLabel548.StylePriority.UseBorders = false;
            this.xrLabel548.StylePriority.UsePadding = false;
            // 
            // xrLabel549
            // 
            this.xrLabel549.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel549.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel549.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel549.Multiline = true;
            this.xrLabel549.Name = "xrLabel549";
            this.xrLabel549.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel549.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel549.StylePriority.UseBorderDashStyle = false;
            this.xrLabel549.StylePriority.UseBorders = false;
            this.xrLabel549.StylePriority.UsePadding = false;
            // 
            // xrLabel550
            // 
            this.xrLabel550.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel550.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel550.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel550.Multiline = true;
            this.xrLabel550.Name = "xrLabel550";
            this.xrLabel550.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel550.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel550.StylePriority.UseBorderDashStyle = false;
            this.xrLabel550.StylePriority.UseBorders = false;
            this.xrLabel550.StylePriority.UsePadding = false;
            // 
            // xrLabel551
            // 
            this.xrLabel551.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel551.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel551.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel551.Multiline = true;
            this.xrLabel551.Name = "xrLabel551";
            this.xrLabel551.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel551.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel551.StylePriority.UseBorderDashStyle = false;
            this.xrLabel551.StylePriority.UseBorders = false;
            this.xrLabel551.StylePriority.UsePadding = false;
            // 
            // xrLabel552
            // 
            this.xrLabel552.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel552.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel552.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel552.Multiline = true;
            this.xrLabel552.Name = "xrLabel552";
            this.xrLabel552.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel552.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel552.StylePriority.UseBorderDashStyle = false;
            this.xrLabel552.StylePriority.UseBorders = false;
            this.xrLabel552.StylePriority.UsePadding = false;
            // 
            // xrTableCell107
            // 
            this.xrTableCell107.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell107.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel553,
            this.xrLabel554,
            this.xrLabel555,
            this.xrLabel556,
            this.xrLabel557,
            this.xrLabel558});
            this.xrTableCell107.Multiline = true;
            this.xrTableCell107.Name = "xrTableCell107";
            this.xrTableCell107.StylePriority.UseBorders = false;
            this.xrTableCell107.Weight = 0.20290247599283853D;
            // 
            // xrLabel553
            // 
            this.xrLabel553.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel553.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel553.Multiline = true;
            this.xrLabel553.Name = "xrLabel553";
            this.xrLabel553.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel553.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel553.StylePriority.UseBorders = false;
            this.xrLabel553.StylePriority.UsePadding = false;
            // 
            // xrLabel554
            // 
            this.xrLabel554.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel554.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel554.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel554.Multiline = true;
            this.xrLabel554.Name = "xrLabel554";
            this.xrLabel554.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel554.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel554.StylePriority.UseBorderDashStyle = false;
            this.xrLabel554.StylePriority.UseBorders = false;
            this.xrLabel554.StylePriority.UsePadding = false;
            // 
            // xrLabel555
            // 
            this.xrLabel555.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel555.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel555.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel555.Multiline = true;
            this.xrLabel555.Name = "xrLabel555";
            this.xrLabel555.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel555.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel555.StylePriority.UseBorderDashStyle = false;
            this.xrLabel555.StylePriority.UseBorders = false;
            this.xrLabel555.StylePriority.UsePadding = false;
            // 
            // xrLabel556
            // 
            this.xrLabel556.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel556.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel556.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel556.Multiline = true;
            this.xrLabel556.Name = "xrLabel556";
            this.xrLabel556.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel556.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel556.StylePriority.UseBorderDashStyle = false;
            this.xrLabel556.StylePriority.UseBorders = false;
            this.xrLabel556.StylePriority.UsePadding = false;
            // 
            // xrLabel557
            // 
            this.xrLabel557.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel557.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel557.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel557.Multiline = true;
            this.xrLabel557.Name = "xrLabel557";
            this.xrLabel557.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel557.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel557.StylePriority.UseBorderDashStyle = false;
            this.xrLabel557.StylePriority.UseBorders = false;
            this.xrLabel557.StylePriority.UsePadding = false;
            // 
            // xrLabel558
            // 
            this.xrLabel558.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel558.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel558.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel558.Multiline = true;
            this.xrLabel558.Name = "xrLabel558";
            this.xrLabel558.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel558.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel558.StylePriority.UseBorderDashStyle = false;
            this.xrLabel558.StylePriority.UseBorders = false;
            this.xrLabel558.StylePriority.UsePadding = false;
            // 
            // xrTableCell108
            // 
            this.xrTableCell108.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell108.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel559,
            this.xrLabel560,
            this.xrLabel561,
            this.xrLabel562,
            this.xrLabel563,
            this.xrLabel564});
            this.xrTableCell108.Multiline = true;
            this.xrTableCell108.Name = "xrTableCell108";
            this.xrTableCell108.StylePriority.UseBorders = false;
            this.xrTableCell108.Weight = 0.20290247599283853D;
            // 
            // xrLabel559
            // 
            this.xrLabel559.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel559.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel559.Multiline = true;
            this.xrLabel559.Name = "xrLabel559";
            this.xrLabel559.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel559.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel559.StylePriority.UseBorders = false;
            this.xrLabel559.StylePriority.UsePadding = false;
            // 
            // xrLabel560
            // 
            this.xrLabel560.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel560.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel560.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel560.Multiline = true;
            this.xrLabel560.Name = "xrLabel560";
            this.xrLabel560.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel560.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel560.StylePriority.UseBorderDashStyle = false;
            this.xrLabel560.StylePriority.UseBorders = false;
            this.xrLabel560.StylePriority.UsePadding = false;
            // 
            // xrLabel561
            // 
            this.xrLabel561.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel561.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel561.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel561.Multiline = true;
            this.xrLabel561.Name = "xrLabel561";
            this.xrLabel561.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel561.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel561.StylePriority.UseBorderDashStyle = false;
            this.xrLabel561.StylePriority.UseBorders = false;
            this.xrLabel561.StylePriority.UsePadding = false;
            // 
            // xrLabel562
            // 
            this.xrLabel562.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel562.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel562.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel562.Multiline = true;
            this.xrLabel562.Name = "xrLabel562";
            this.xrLabel562.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel562.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel562.StylePriority.UseBorderDashStyle = false;
            this.xrLabel562.StylePriority.UseBorders = false;
            this.xrLabel562.StylePriority.UsePadding = false;
            // 
            // xrLabel563
            // 
            this.xrLabel563.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel563.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel563.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel563.Multiline = true;
            this.xrLabel563.Name = "xrLabel563";
            this.xrLabel563.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel563.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel563.StylePriority.UseBorderDashStyle = false;
            this.xrLabel563.StylePriority.UseBorders = false;
            this.xrLabel563.StylePriority.UsePadding = false;
            // 
            // xrLabel564
            // 
            this.xrLabel564.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel564.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel564.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel564.Multiline = true;
            this.xrLabel564.Name = "xrLabel564";
            this.xrLabel564.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel564.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel564.StylePriority.UseBorderDashStyle = false;
            this.xrLabel564.StylePriority.UseBorders = false;
            this.xrLabel564.StylePriority.UsePadding = false;
            // 
            // xrTableCell109
            // 
            this.xrTableCell109.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell109.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel565,
            this.xrLabel566,
            this.xrLabel567,
            this.xrLabel568,
            this.xrLabel569,
            this.xrLabel570});
            this.xrTableCell109.Multiline = true;
            this.xrTableCell109.Name = "xrTableCell109";
            this.xrTableCell109.StylePriority.UseBorders = false;
            this.xrTableCell109.Weight = 0.20290247599283853D;
            // 
            // xrLabel565
            // 
            this.xrLabel565.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel565.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel565.Multiline = true;
            this.xrLabel565.Name = "xrLabel565";
            this.xrLabel565.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel565.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel565.StylePriority.UseBorders = false;
            this.xrLabel565.StylePriority.UsePadding = false;
            // 
            // xrLabel566
            // 
            this.xrLabel566.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel566.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel566.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel566.Multiline = true;
            this.xrLabel566.Name = "xrLabel566";
            this.xrLabel566.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel566.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel566.StylePriority.UseBorderDashStyle = false;
            this.xrLabel566.StylePriority.UseBorders = false;
            this.xrLabel566.StylePriority.UsePadding = false;
            // 
            // xrLabel567
            // 
            this.xrLabel567.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel567.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel567.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel567.Multiline = true;
            this.xrLabel567.Name = "xrLabel567";
            this.xrLabel567.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel567.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel567.StylePriority.UseBorderDashStyle = false;
            this.xrLabel567.StylePriority.UseBorders = false;
            this.xrLabel567.StylePriority.UsePadding = false;
            // 
            // xrLabel568
            // 
            this.xrLabel568.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel568.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel568.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel568.Multiline = true;
            this.xrLabel568.Name = "xrLabel568";
            this.xrLabel568.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel568.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel568.StylePriority.UseBorderDashStyle = false;
            this.xrLabel568.StylePriority.UseBorders = false;
            this.xrLabel568.StylePriority.UsePadding = false;
            // 
            // xrLabel569
            // 
            this.xrLabel569.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel569.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel569.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel569.Multiline = true;
            this.xrLabel569.Name = "xrLabel569";
            this.xrLabel569.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel569.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel569.StylePriority.UseBorderDashStyle = false;
            this.xrLabel569.StylePriority.UseBorders = false;
            this.xrLabel569.StylePriority.UsePadding = false;
            // 
            // xrLabel570
            // 
            this.xrLabel570.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel570.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel570.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel570.Multiline = true;
            this.xrLabel570.Name = "xrLabel570";
            this.xrLabel570.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel570.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel570.StylePriority.UseBorderDashStyle = false;
            this.xrLabel570.StylePriority.UseBorders = false;
            this.xrLabel570.StylePriority.UsePadding = false;
            // 
            // xrTableCell110
            // 
            this.xrTableCell110.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell110.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel571,
            this.xrLabel572,
            this.xrLabel573,
            this.xrLabel574,
            this.xrLabel575,
            this.xrLabel576});
            this.xrTableCell110.Multiline = true;
            this.xrTableCell110.Name = "xrTableCell110";
            this.xrTableCell110.StylePriority.UseBorders = false;
            this.xrTableCell110.Weight = 0.20290247599283853D;
            // 
            // xrLabel571
            // 
            this.xrLabel571.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel571.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel571.Multiline = true;
            this.xrLabel571.Name = "xrLabel571";
            this.xrLabel571.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel571.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel571.StylePriority.UseBorders = false;
            this.xrLabel571.StylePriority.UsePadding = false;
            // 
            // xrLabel572
            // 
            this.xrLabel572.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel572.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel572.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel572.Multiline = true;
            this.xrLabel572.Name = "xrLabel572";
            this.xrLabel572.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel572.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel572.StylePriority.UseBorderDashStyle = false;
            this.xrLabel572.StylePriority.UseBorders = false;
            this.xrLabel572.StylePriority.UsePadding = false;
            // 
            // xrLabel573
            // 
            this.xrLabel573.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel573.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel573.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel573.Multiline = true;
            this.xrLabel573.Name = "xrLabel573";
            this.xrLabel573.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel573.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel573.StylePriority.UseBorderDashStyle = false;
            this.xrLabel573.StylePriority.UseBorders = false;
            this.xrLabel573.StylePriority.UsePadding = false;
            // 
            // xrLabel574
            // 
            this.xrLabel574.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel574.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel574.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel574.Multiline = true;
            this.xrLabel574.Name = "xrLabel574";
            this.xrLabel574.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel574.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel574.StylePriority.UseBorderDashStyle = false;
            this.xrLabel574.StylePriority.UseBorders = false;
            this.xrLabel574.StylePriority.UsePadding = false;
            // 
            // xrLabel575
            // 
            this.xrLabel575.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel575.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel575.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel575.Multiline = true;
            this.xrLabel575.Name = "xrLabel575";
            this.xrLabel575.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel575.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel575.StylePriority.UseBorderDashStyle = false;
            this.xrLabel575.StylePriority.UseBorders = false;
            this.xrLabel575.StylePriority.UsePadding = false;
            // 
            // xrLabel576
            // 
            this.xrLabel576.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel576.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel576.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel576.Multiline = true;
            this.xrLabel576.Name = "xrLabel576";
            this.xrLabel576.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel576.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel576.StylePriority.UseBorderDashStyle = false;
            this.xrLabel576.StylePriority.UseBorders = false;
            this.xrLabel576.StylePriority.UsePadding = false;
            // 
            // xrTableCell111
            // 
            this.xrTableCell111.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell111.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel577,
            this.xrLabel578,
            this.xrLabel579,
            this.xrLabel580,
            this.xrLabel581,
            this.xrLabel582});
            this.xrTableCell111.Multiline = true;
            this.xrTableCell111.Name = "xrTableCell111";
            this.xrTableCell111.StylePriority.UseBorders = false;
            this.xrTableCell111.Weight = 0.20290247599283853D;
            // 
            // xrLabel577
            // 
            this.xrLabel577.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel577.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel577.Multiline = true;
            this.xrLabel577.Name = "xrLabel577";
            this.xrLabel577.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel577.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel577.StylePriority.UseBorders = false;
            this.xrLabel577.StylePriority.UsePadding = false;
            // 
            // xrLabel578
            // 
            this.xrLabel578.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel578.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel578.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel578.Multiline = true;
            this.xrLabel578.Name = "xrLabel578";
            this.xrLabel578.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel578.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel578.StylePriority.UseBorderDashStyle = false;
            this.xrLabel578.StylePriority.UseBorders = false;
            this.xrLabel578.StylePriority.UsePadding = false;
            // 
            // xrLabel579
            // 
            this.xrLabel579.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel579.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel579.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel579.Multiline = true;
            this.xrLabel579.Name = "xrLabel579";
            this.xrLabel579.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel579.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel579.StylePriority.UseBorderDashStyle = false;
            this.xrLabel579.StylePriority.UseBorders = false;
            this.xrLabel579.StylePriority.UsePadding = false;
            // 
            // xrLabel580
            // 
            this.xrLabel580.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel580.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel580.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel580.Multiline = true;
            this.xrLabel580.Name = "xrLabel580";
            this.xrLabel580.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel580.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel580.StylePriority.UseBorderDashStyle = false;
            this.xrLabel580.StylePriority.UseBorders = false;
            this.xrLabel580.StylePriority.UsePadding = false;
            // 
            // xrLabel581
            // 
            this.xrLabel581.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel581.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel581.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel581.Multiline = true;
            this.xrLabel581.Name = "xrLabel581";
            this.xrLabel581.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel581.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel581.StylePriority.UseBorderDashStyle = false;
            this.xrLabel581.StylePriority.UseBorders = false;
            this.xrLabel581.StylePriority.UsePadding = false;
            // 
            // xrLabel582
            // 
            this.xrLabel582.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel582.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel582.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel582.Multiline = true;
            this.xrLabel582.Name = "xrLabel582";
            this.xrLabel582.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel582.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel582.StylePriority.UseBorderDashStyle = false;
            this.xrLabel582.StylePriority.UseBorders = false;
            this.xrLabel582.StylePriority.UsePadding = false;
            // 
            // xrTableCell112
            // 
            this.xrTableCell112.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell112.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel583,
            this.xrLabel584,
            this.xrLabel585,
            this.xrLabel586,
            this.xrLabel587,
            this.xrLabel588});
            this.xrTableCell112.Multiline = true;
            this.xrTableCell112.Name = "xrTableCell112";
            this.xrTableCell112.StylePriority.UseBorders = false;
            this.xrTableCell112.Weight = 0.20290247599283853D;
            // 
            // xrLabel583
            // 
            this.xrLabel583.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel583.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel583.Multiline = true;
            this.xrLabel583.Name = "xrLabel583";
            this.xrLabel583.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel583.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel583.StylePriority.UseBorders = false;
            this.xrLabel583.StylePriority.UsePadding = false;
            // 
            // xrLabel584
            // 
            this.xrLabel584.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel584.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel584.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel584.Multiline = true;
            this.xrLabel584.Name = "xrLabel584";
            this.xrLabel584.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel584.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel584.StylePriority.UseBorderDashStyle = false;
            this.xrLabel584.StylePriority.UseBorders = false;
            this.xrLabel584.StylePriority.UsePadding = false;
            // 
            // xrLabel585
            // 
            this.xrLabel585.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel585.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel585.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel585.Multiline = true;
            this.xrLabel585.Name = "xrLabel585";
            this.xrLabel585.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel585.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel585.StylePriority.UseBorderDashStyle = false;
            this.xrLabel585.StylePriority.UseBorders = false;
            this.xrLabel585.StylePriority.UsePadding = false;
            // 
            // xrLabel586
            // 
            this.xrLabel586.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel586.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel586.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel586.Multiline = true;
            this.xrLabel586.Name = "xrLabel586";
            this.xrLabel586.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel586.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel586.StylePriority.UseBorderDashStyle = false;
            this.xrLabel586.StylePriority.UseBorders = false;
            this.xrLabel586.StylePriority.UsePadding = false;
            // 
            // xrLabel587
            // 
            this.xrLabel587.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel587.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel587.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel587.Multiline = true;
            this.xrLabel587.Name = "xrLabel587";
            this.xrLabel587.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel587.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel587.StylePriority.UseBorderDashStyle = false;
            this.xrLabel587.StylePriority.UseBorders = false;
            this.xrLabel587.StylePriority.UsePadding = false;
            // 
            // xrLabel588
            // 
            this.xrLabel588.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel588.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel588.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel588.Multiline = true;
            this.xrLabel588.Name = "xrLabel588";
            this.xrLabel588.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel588.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel588.StylePriority.UseBorderDashStyle = false;
            this.xrLabel588.StylePriority.UseBorders = false;
            this.xrLabel588.StylePriority.UsePadding = false;
            // 
            // xrTableCell113
            // 
            this.xrTableCell113.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell113.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel589,
            this.xrLabel590,
            this.xrLabel591,
            this.xrLabel592,
            this.xrLabel593,
            this.xrLabel594});
            this.xrTableCell113.Multiline = true;
            this.xrTableCell113.Name = "xrTableCell113";
            this.xrTableCell113.StylePriority.UseBorders = false;
            this.xrTableCell113.Weight = 0.20290247599283853D;
            // 
            // xrLabel589
            // 
            this.xrLabel589.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel589.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel589.Multiline = true;
            this.xrLabel589.Name = "xrLabel589";
            this.xrLabel589.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel589.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel589.StylePriority.UseBorders = false;
            this.xrLabel589.StylePriority.UsePadding = false;
            // 
            // xrLabel590
            // 
            this.xrLabel590.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel590.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel590.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel590.Multiline = true;
            this.xrLabel590.Name = "xrLabel590";
            this.xrLabel590.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel590.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel590.StylePriority.UseBorderDashStyle = false;
            this.xrLabel590.StylePriority.UseBorders = false;
            this.xrLabel590.StylePriority.UsePadding = false;
            // 
            // xrLabel591
            // 
            this.xrLabel591.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel591.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel591.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel591.Multiline = true;
            this.xrLabel591.Name = "xrLabel591";
            this.xrLabel591.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel591.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel591.StylePriority.UseBorderDashStyle = false;
            this.xrLabel591.StylePriority.UseBorders = false;
            this.xrLabel591.StylePriority.UsePadding = false;
            // 
            // xrLabel592
            // 
            this.xrLabel592.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel592.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel592.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel592.Multiline = true;
            this.xrLabel592.Name = "xrLabel592";
            this.xrLabel592.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel592.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel592.StylePriority.UseBorderDashStyle = false;
            this.xrLabel592.StylePriority.UseBorders = false;
            this.xrLabel592.StylePriority.UsePadding = false;
            // 
            // xrLabel593
            // 
            this.xrLabel593.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel593.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel593.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel593.Multiline = true;
            this.xrLabel593.Name = "xrLabel593";
            this.xrLabel593.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel593.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel593.StylePriority.UseBorderDashStyle = false;
            this.xrLabel593.StylePriority.UseBorders = false;
            this.xrLabel593.StylePriority.UsePadding = false;
            // 
            // xrLabel594
            // 
            this.xrLabel594.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel594.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel594.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel594.Multiline = true;
            this.xrLabel594.Name = "xrLabel594";
            this.xrLabel594.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel594.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel594.StylePriority.UseBorderDashStyle = false;
            this.xrLabel594.StylePriority.UseBorders = false;
            this.xrLabel594.StylePriority.UsePadding = false;
            // 
            // xrTableCell114
            // 
            this.xrTableCell114.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell114.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel595,
            this.xrLabel596,
            this.xrLabel597,
            this.xrLabel598,
            this.xrLabel599,
            this.xrLabel600});
            this.xrTableCell114.Multiline = true;
            this.xrTableCell114.Name = "xrTableCell114";
            this.xrTableCell114.StylePriority.UseBorders = false;
            this.xrTableCell114.Weight = 0.20290247599283853D;
            // 
            // xrLabel595
            // 
            this.xrLabel595.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel595.LocationFloat = new DevExpress.Utils.PointFloat(0F, 74.99985F);
            this.xrLabel595.Multiline = true;
            this.xrLabel595.Name = "xrLabel595";
            this.xrLabel595.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel595.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel595.StylePriority.UseBorders = false;
            this.xrLabel595.StylePriority.UsePadding = false;
            // 
            // xrLabel596
            // 
            this.xrLabel596.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel596.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel596.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel596.Multiline = true;
            this.xrLabel596.Name = "xrLabel596";
            this.xrLabel596.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel596.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel596.StylePriority.UseBorderDashStyle = false;
            this.xrLabel596.StylePriority.UseBorders = false;
            this.xrLabel596.StylePriority.UsePadding = false;
            // 
            // xrLabel597
            // 
            this.xrLabel597.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel597.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel597.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel597.Multiline = true;
            this.xrLabel597.Name = "xrLabel597";
            this.xrLabel597.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel597.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel597.StylePriority.UseBorderDashStyle = false;
            this.xrLabel597.StylePriority.UseBorders = false;
            this.xrLabel597.StylePriority.UsePadding = false;
            // 
            // xrLabel598
            // 
            this.xrLabel598.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel598.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel598.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel598.Multiline = true;
            this.xrLabel598.Name = "xrLabel598";
            this.xrLabel598.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel598.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel598.StylePriority.UseBorderDashStyle = false;
            this.xrLabel598.StylePriority.UseBorders = false;
            this.xrLabel598.StylePriority.UsePadding = false;
            // 
            // xrLabel599
            // 
            this.xrLabel599.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel599.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel599.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel599.Multiline = true;
            this.xrLabel599.Name = "xrLabel599";
            this.xrLabel599.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel599.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel599.StylePriority.UseBorderDashStyle = false;
            this.xrLabel599.StylePriority.UseBorders = false;
            this.xrLabel599.StylePriority.UsePadding = false;
            // 
            // xrLabel600
            // 
            this.xrLabel600.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel600.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel600.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel600.Multiline = true;
            this.xrLabel600.Name = "xrLabel600";
            this.xrLabel600.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel600.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel600.StylePriority.UseBorderDashStyle = false;
            this.xrLabel600.StylePriority.UseBorders = false;
            this.xrLabel600.StylePriority.UsePadding = false;
            // 
            // xrTable10
            // 
            this.xrTable10.LocationFloat = new DevExpress.Utils.PointFloat(0.0003051758F, 478.3795F);
            this.xrTable10.Name = "xrTable10";
            this.xrTable10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable10.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow10});
            this.xrTable10.SizeF = new System.Drawing.SizeF(372.019F, 90.38583F);
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell91,
            this.xrTableCell92,
            this.xrTableCell93,
            this.xrTableCell94,
            this.xrTableCell95,
            this.xrTableCell96,
            this.xrTableCell97,
            this.xrTableCell98,
            this.xrTableCell99,
            this.xrTableCell100,
            this.xrTableCell101,
            this.xrTableCell102});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 1D;
            // 
            // xrTableCell91
            // 
            this.xrTableCell91.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell91.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel457,
            this.xrLabel458,
            this.xrLabel459,
            this.xrLabel460,
            this.xrLabel461,
            this.xrLabel462});
            this.xrTableCell91.Multiline = true;
            this.xrTableCell91.Name = "xrTableCell91";
            this.xrTableCell91.StylePriority.UseBorders = false;
            this.xrTableCell91.Weight = 0.20290247599283853D;
            // 
            // xrLabel457
            // 
            this.xrLabel457.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel457.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel457.Multiline = true;
            this.xrLabel457.Name = "xrLabel457";
            this.xrLabel457.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel457.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel457.StylePriority.UseBorders = false;
            this.xrLabel457.StylePriority.UsePadding = false;
            // 
            // xrLabel458
            // 
            this.xrLabel458.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel458.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel458.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel458.Multiline = true;
            this.xrLabel458.Name = "xrLabel458";
            this.xrLabel458.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel458.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel458.StylePriority.UseBorderDashStyle = false;
            this.xrLabel458.StylePriority.UseBorders = false;
            this.xrLabel458.StylePriority.UsePadding = false;
            // 
            // xrLabel459
            // 
            this.xrLabel459.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel459.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel459.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel459.Multiline = true;
            this.xrLabel459.Name = "xrLabel459";
            this.xrLabel459.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel459.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel459.StylePriority.UseBorderDashStyle = false;
            this.xrLabel459.StylePriority.UseBorders = false;
            this.xrLabel459.StylePriority.UsePadding = false;
            // 
            // xrLabel460
            // 
            this.xrLabel460.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel460.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel460.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel460.Multiline = true;
            this.xrLabel460.Name = "xrLabel460";
            this.xrLabel460.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel460.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel460.StylePriority.UseBorderDashStyle = false;
            this.xrLabel460.StylePriority.UseBorders = false;
            this.xrLabel460.StylePriority.UsePadding = false;
            // 
            // xrLabel461
            // 
            this.xrLabel461.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel461.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel461.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel461.Multiline = true;
            this.xrLabel461.Name = "xrLabel461";
            this.xrLabel461.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel461.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel461.StylePriority.UseBorderDashStyle = false;
            this.xrLabel461.StylePriority.UseBorders = false;
            this.xrLabel461.StylePriority.UsePadding = false;
            // 
            // xrLabel462
            // 
            this.xrLabel462.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel462.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel462.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel462.Multiline = true;
            this.xrLabel462.Name = "xrLabel462";
            this.xrLabel462.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel462.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel462.StylePriority.UseBorderDashStyle = false;
            this.xrLabel462.StylePriority.UseBorders = false;
            this.xrLabel462.StylePriority.UsePadding = false;
            // 
            // xrTableCell92
            // 
            this.xrTableCell92.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell92.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel463,
            this.xrLabel464,
            this.xrLabel465,
            this.xrLabel466,
            this.xrLabel467,
            this.xrLabel468});
            this.xrTableCell92.Multiline = true;
            this.xrTableCell92.Name = "xrTableCell92";
            this.xrTableCell92.StylePriority.UseBorders = false;
            this.xrTableCell92.Weight = 0.20290247599283853D;
            // 
            // xrLabel463
            // 
            this.xrLabel463.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel463.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel463.Multiline = true;
            this.xrLabel463.Name = "xrLabel463";
            this.xrLabel463.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel463.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel463.StylePriority.UseBorders = false;
            this.xrLabel463.StylePriority.UsePadding = false;
            // 
            // xrLabel464
            // 
            this.xrLabel464.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel464.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel464.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel464.Multiline = true;
            this.xrLabel464.Name = "xrLabel464";
            this.xrLabel464.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel464.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel464.StylePriority.UseBorderDashStyle = false;
            this.xrLabel464.StylePriority.UseBorders = false;
            this.xrLabel464.StylePriority.UsePadding = false;
            // 
            // xrLabel465
            // 
            this.xrLabel465.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel465.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel465.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel465.Multiline = true;
            this.xrLabel465.Name = "xrLabel465";
            this.xrLabel465.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel465.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel465.StylePriority.UseBorderDashStyle = false;
            this.xrLabel465.StylePriority.UseBorders = false;
            this.xrLabel465.StylePriority.UsePadding = false;
            // 
            // xrLabel466
            // 
            this.xrLabel466.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel466.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel466.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel466.Multiline = true;
            this.xrLabel466.Name = "xrLabel466";
            this.xrLabel466.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel466.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel466.StylePriority.UseBorderDashStyle = false;
            this.xrLabel466.StylePriority.UseBorders = false;
            this.xrLabel466.StylePriority.UsePadding = false;
            // 
            // xrLabel467
            // 
            this.xrLabel467.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel467.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel467.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel467.Multiline = true;
            this.xrLabel467.Name = "xrLabel467";
            this.xrLabel467.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel467.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel467.StylePriority.UseBorderDashStyle = false;
            this.xrLabel467.StylePriority.UseBorders = false;
            this.xrLabel467.StylePriority.UsePadding = false;
            // 
            // xrLabel468
            // 
            this.xrLabel468.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel468.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel468.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel468.Multiline = true;
            this.xrLabel468.Name = "xrLabel468";
            this.xrLabel468.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel468.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel468.StylePriority.UseBorderDashStyle = false;
            this.xrLabel468.StylePriority.UseBorders = false;
            this.xrLabel468.StylePriority.UsePadding = false;
            // 
            // xrTableCell93
            // 
            this.xrTableCell93.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell93.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel469,
            this.xrLabel470,
            this.xrLabel471,
            this.xrLabel472,
            this.xrLabel473,
            this.xrLabel474});
            this.xrTableCell93.Multiline = true;
            this.xrTableCell93.Name = "xrTableCell93";
            this.xrTableCell93.StylePriority.UseBorders = false;
            this.xrTableCell93.Weight = 0.20290247599283853D;
            // 
            // xrLabel469
            // 
            this.xrLabel469.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel469.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel469.Multiline = true;
            this.xrLabel469.Name = "xrLabel469";
            this.xrLabel469.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel469.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel469.StylePriority.UseBorders = false;
            this.xrLabel469.StylePriority.UsePadding = false;
            // 
            // xrLabel470
            // 
            this.xrLabel470.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel470.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel470.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel470.Multiline = true;
            this.xrLabel470.Name = "xrLabel470";
            this.xrLabel470.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel470.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel470.StylePriority.UseBorderDashStyle = false;
            this.xrLabel470.StylePriority.UseBorders = false;
            this.xrLabel470.StylePriority.UsePadding = false;
            // 
            // xrLabel471
            // 
            this.xrLabel471.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel471.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel471.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel471.Multiline = true;
            this.xrLabel471.Name = "xrLabel471";
            this.xrLabel471.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel471.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel471.StylePriority.UseBorderDashStyle = false;
            this.xrLabel471.StylePriority.UseBorders = false;
            this.xrLabel471.StylePriority.UsePadding = false;
            // 
            // xrLabel472
            // 
            this.xrLabel472.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel472.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel472.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel472.Multiline = true;
            this.xrLabel472.Name = "xrLabel472";
            this.xrLabel472.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel472.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel472.StylePriority.UseBorderDashStyle = false;
            this.xrLabel472.StylePriority.UseBorders = false;
            this.xrLabel472.StylePriority.UsePadding = false;
            // 
            // xrLabel473
            // 
            this.xrLabel473.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel473.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel473.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel473.Multiline = true;
            this.xrLabel473.Name = "xrLabel473";
            this.xrLabel473.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel473.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel473.StylePriority.UseBorderDashStyle = false;
            this.xrLabel473.StylePriority.UseBorders = false;
            this.xrLabel473.StylePriority.UsePadding = false;
            // 
            // xrLabel474
            // 
            this.xrLabel474.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel474.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel474.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel474.Multiline = true;
            this.xrLabel474.Name = "xrLabel474";
            this.xrLabel474.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel474.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel474.StylePriority.UseBorderDashStyle = false;
            this.xrLabel474.StylePriority.UseBorders = false;
            this.xrLabel474.StylePriority.UsePadding = false;
            // 
            // xrTableCell94
            // 
            this.xrTableCell94.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell94.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel475,
            this.xrLabel476,
            this.xrLabel477,
            this.xrLabel478,
            this.xrLabel479,
            this.xrLabel480});
            this.xrTableCell94.Multiline = true;
            this.xrTableCell94.Name = "xrTableCell94";
            this.xrTableCell94.StylePriority.UseBorders = false;
            this.xrTableCell94.Weight = 0.20290247599283853D;
            // 
            // xrLabel475
            // 
            this.xrLabel475.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel475.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel475.Multiline = true;
            this.xrLabel475.Name = "xrLabel475";
            this.xrLabel475.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel475.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel475.StylePriority.UseBorders = false;
            this.xrLabel475.StylePriority.UsePadding = false;
            // 
            // xrLabel476
            // 
            this.xrLabel476.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel476.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel476.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel476.Multiline = true;
            this.xrLabel476.Name = "xrLabel476";
            this.xrLabel476.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel476.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel476.StylePriority.UseBorderDashStyle = false;
            this.xrLabel476.StylePriority.UseBorders = false;
            this.xrLabel476.StylePriority.UsePadding = false;
            // 
            // xrLabel477
            // 
            this.xrLabel477.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel477.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel477.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel477.Multiline = true;
            this.xrLabel477.Name = "xrLabel477";
            this.xrLabel477.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel477.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel477.StylePriority.UseBorderDashStyle = false;
            this.xrLabel477.StylePriority.UseBorders = false;
            this.xrLabel477.StylePriority.UsePadding = false;
            // 
            // xrLabel478
            // 
            this.xrLabel478.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel478.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel478.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel478.Multiline = true;
            this.xrLabel478.Name = "xrLabel478";
            this.xrLabel478.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel478.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel478.StylePriority.UseBorderDashStyle = false;
            this.xrLabel478.StylePriority.UseBorders = false;
            this.xrLabel478.StylePriority.UsePadding = false;
            // 
            // xrLabel479
            // 
            this.xrLabel479.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel479.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel479.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel479.Multiline = true;
            this.xrLabel479.Name = "xrLabel479";
            this.xrLabel479.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel479.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel479.StylePriority.UseBorderDashStyle = false;
            this.xrLabel479.StylePriority.UseBorders = false;
            this.xrLabel479.StylePriority.UsePadding = false;
            // 
            // xrLabel480
            // 
            this.xrLabel480.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel480.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel480.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel480.Multiline = true;
            this.xrLabel480.Name = "xrLabel480";
            this.xrLabel480.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel480.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel480.StylePriority.UseBorderDashStyle = false;
            this.xrLabel480.StylePriority.UseBorders = false;
            this.xrLabel480.StylePriority.UsePadding = false;
            // 
            // xrTableCell95
            // 
            this.xrTableCell95.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell95.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel481,
            this.xrLabel482,
            this.xrLabel483,
            this.xrLabel484,
            this.xrLabel485,
            this.xrLabel486});
            this.xrTableCell95.Multiline = true;
            this.xrTableCell95.Name = "xrTableCell95";
            this.xrTableCell95.StylePriority.UseBorders = false;
            this.xrTableCell95.Weight = 0.20290247599283853D;
            // 
            // xrLabel481
            // 
            this.xrLabel481.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel481.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel481.Multiline = true;
            this.xrLabel481.Name = "xrLabel481";
            this.xrLabel481.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel481.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel481.StylePriority.UseBorders = false;
            this.xrLabel481.StylePriority.UsePadding = false;
            // 
            // xrLabel482
            // 
            this.xrLabel482.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel482.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel482.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel482.Multiline = true;
            this.xrLabel482.Name = "xrLabel482";
            this.xrLabel482.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel482.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel482.StylePriority.UseBorderDashStyle = false;
            this.xrLabel482.StylePriority.UseBorders = false;
            this.xrLabel482.StylePriority.UsePadding = false;
            // 
            // xrLabel483
            // 
            this.xrLabel483.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel483.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel483.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel483.Multiline = true;
            this.xrLabel483.Name = "xrLabel483";
            this.xrLabel483.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel483.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel483.StylePriority.UseBorderDashStyle = false;
            this.xrLabel483.StylePriority.UseBorders = false;
            this.xrLabel483.StylePriority.UsePadding = false;
            // 
            // xrLabel484
            // 
            this.xrLabel484.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel484.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel484.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel484.Multiline = true;
            this.xrLabel484.Name = "xrLabel484";
            this.xrLabel484.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel484.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel484.StylePriority.UseBorderDashStyle = false;
            this.xrLabel484.StylePriority.UseBorders = false;
            this.xrLabel484.StylePriority.UsePadding = false;
            // 
            // xrLabel485
            // 
            this.xrLabel485.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel485.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel485.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel485.Multiline = true;
            this.xrLabel485.Name = "xrLabel485";
            this.xrLabel485.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel485.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel485.StylePriority.UseBorderDashStyle = false;
            this.xrLabel485.StylePriority.UseBorders = false;
            this.xrLabel485.StylePriority.UsePadding = false;
            // 
            // xrLabel486
            // 
            this.xrLabel486.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel486.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel486.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel486.Multiline = true;
            this.xrLabel486.Name = "xrLabel486";
            this.xrLabel486.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel486.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel486.StylePriority.UseBorderDashStyle = false;
            this.xrLabel486.StylePriority.UseBorders = false;
            this.xrLabel486.StylePriority.UsePadding = false;
            // 
            // xrTableCell96
            // 
            this.xrTableCell96.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell96.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel487,
            this.xrLabel488,
            this.xrLabel489,
            this.xrLabel490,
            this.xrLabel491,
            this.xrLabel492});
            this.xrTableCell96.Multiline = true;
            this.xrTableCell96.Name = "xrTableCell96";
            this.xrTableCell96.StylePriority.UseBorders = false;
            this.xrTableCell96.Weight = 0.20290247599283853D;
            // 
            // xrLabel487
            // 
            this.xrLabel487.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel487.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel487.Multiline = true;
            this.xrLabel487.Name = "xrLabel487";
            this.xrLabel487.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel487.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel487.StylePriority.UseBorders = false;
            this.xrLabel487.StylePriority.UsePadding = false;
            // 
            // xrLabel488
            // 
            this.xrLabel488.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel488.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel488.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel488.Multiline = true;
            this.xrLabel488.Name = "xrLabel488";
            this.xrLabel488.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel488.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel488.StylePriority.UseBorderDashStyle = false;
            this.xrLabel488.StylePriority.UseBorders = false;
            this.xrLabel488.StylePriority.UsePadding = false;
            // 
            // xrLabel489
            // 
            this.xrLabel489.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel489.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel489.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel489.Multiline = true;
            this.xrLabel489.Name = "xrLabel489";
            this.xrLabel489.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel489.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel489.StylePriority.UseBorderDashStyle = false;
            this.xrLabel489.StylePriority.UseBorders = false;
            this.xrLabel489.StylePriority.UsePadding = false;
            // 
            // xrLabel490
            // 
            this.xrLabel490.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel490.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel490.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel490.Multiline = true;
            this.xrLabel490.Name = "xrLabel490";
            this.xrLabel490.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel490.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel490.StylePriority.UseBorderDashStyle = false;
            this.xrLabel490.StylePriority.UseBorders = false;
            this.xrLabel490.StylePriority.UsePadding = false;
            // 
            // xrLabel491
            // 
            this.xrLabel491.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel491.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel491.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel491.Multiline = true;
            this.xrLabel491.Name = "xrLabel491";
            this.xrLabel491.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel491.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel491.StylePriority.UseBorderDashStyle = false;
            this.xrLabel491.StylePriority.UseBorders = false;
            this.xrLabel491.StylePriority.UsePadding = false;
            // 
            // xrLabel492
            // 
            this.xrLabel492.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel492.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel492.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel492.Multiline = true;
            this.xrLabel492.Name = "xrLabel492";
            this.xrLabel492.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel492.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel492.StylePriority.UseBorderDashStyle = false;
            this.xrLabel492.StylePriority.UseBorders = false;
            this.xrLabel492.StylePriority.UsePadding = false;
            // 
            // xrTableCell97
            // 
            this.xrTableCell97.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell97.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel493,
            this.xrLabel494,
            this.xrLabel495,
            this.xrLabel496,
            this.xrLabel497,
            this.xrLabel498});
            this.xrTableCell97.Multiline = true;
            this.xrTableCell97.Name = "xrTableCell97";
            this.xrTableCell97.StylePriority.UseBorders = false;
            this.xrTableCell97.Weight = 0.20290247599283853D;
            // 
            // xrLabel493
            // 
            this.xrLabel493.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel493.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel493.Multiline = true;
            this.xrLabel493.Name = "xrLabel493";
            this.xrLabel493.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel493.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel493.StylePriority.UseBorders = false;
            this.xrLabel493.StylePriority.UsePadding = false;
            // 
            // xrLabel494
            // 
            this.xrLabel494.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel494.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel494.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel494.Multiline = true;
            this.xrLabel494.Name = "xrLabel494";
            this.xrLabel494.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel494.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel494.StylePriority.UseBorderDashStyle = false;
            this.xrLabel494.StylePriority.UseBorders = false;
            this.xrLabel494.StylePriority.UsePadding = false;
            // 
            // xrLabel495
            // 
            this.xrLabel495.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel495.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel495.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel495.Multiline = true;
            this.xrLabel495.Name = "xrLabel495";
            this.xrLabel495.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel495.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel495.StylePriority.UseBorderDashStyle = false;
            this.xrLabel495.StylePriority.UseBorders = false;
            this.xrLabel495.StylePriority.UsePadding = false;
            // 
            // xrLabel496
            // 
            this.xrLabel496.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel496.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel496.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel496.Multiline = true;
            this.xrLabel496.Name = "xrLabel496";
            this.xrLabel496.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel496.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel496.StylePriority.UseBorderDashStyle = false;
            this.xrLabel496.StylePriority.UseBorders = false;
            this.xrLabel496.StylePriority.UsePadding = false;
            // 
            // xrLabel497
            // 
            this.xrLabel497.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel497.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel497.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel497.Multiline = true;
            this.xrLabel497.Name = "xrLabel497";
            this.xrLabel497.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel497.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel497.StylePriority.UseBorderDashStyle = false;
            this.xrLabel497.StylePriority.UseBorders = false;
            this.xrLabel497.StylePriority.UsePadding = false;
            // 
            // xrLabel498
            // 
            this.xrLabel498.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel498.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel498.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel498.Multiline = true;
            this.xrLabel498.Name = "xrLabel498";
            this.xrLabel498.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel498.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel498.StylePriority.UseBorderDashStyle = false;
            this.xrLabel498.StylePriority.UseBorders = false;
            this.xrLabel498.StylePriority.UsePadding = false;
            // 
            // xrTableCell98
            // 
            this.xrTableCell98.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell98.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel499,
            this.xrLabel500,
            this.xrLabel501,
            this.xrLabel502,
            this.xrLabel503,
            this.xrLabel504});
            this.xrTableCell98.Multiline = true;
            this.xrTableCell98.Name = "xrTableCell98";
            this.xrTableCell98.StylePriority.UseBorders = false;
            this.xrTableCell98.Weight = 0.20290247599283853D;
            // 
            // xrLabel499
            // 
            this.xrLabel499.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel499.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel499.Multiline = true;
            this.xrLabel499.Name = "xrLabel499";
            this.xrLabel499.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel499.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel499.StylePriority.UseBorders = false;
            this.xrLabel499.StylePriority.UsePadding = false;
            // 
            // xrLabel500
            // 
            this.xrLabel500.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel500.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel500.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel500.Multiline = true;
            this.xrLabel500.Name = "xrLabel500";
            this.xrLabel500.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel500.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel500.StylePriority.UseBorderDashStyle = false;
            this.xrLabel500.StylePriority.UseBorders = false;
            this.xrLabel500.StylePriority.UsePadding = false;
            // 
            // xrLabel501
            // 
            this.xrLabel501.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel501.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel501.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel501.Multiline = true;
            this.xrLabel501.Name = "xrLabel501";
            this.xrLabel501.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel501.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel501.StylePriority.UseBorderDashStyle = false;
            this.xrLabel501.StylePriority.UseBorders = false;
            this.xrLabel501.StylePriority.UsePadding = false;
            // 
            // xrLabel502
            // 
            this.xrLabel502.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel502.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel502.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel502.Multiline = true;
            this.xrLabel502.Name = "xrLabel502";
            this.xrLabel502.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel502.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel502.StylePriority.UseBorderDashStyle = false;
            this.xrLabel502.StylePriority.UseBorders = false;
            this.xrLabel502.StylePriority.UsePadding = false;
            // 
            // xrLabel503
            // 
            this.xrLabel503.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel503.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel503.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel503.Multiline = true;
            this.xrLabel503.Name = "xrLabel503";
            this.xrLabel503.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel503.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel503.StylePriority.UseBorderDashStyle = false;
            this.xrLabel503.StylePriority.UseBorders = false;
            this.xrLabel503.StylePriority.UsePadding = false;
            // 
            // xrLabel504
            // 
            this.xrLabel504.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel504.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel504.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel504.Multiline = true;
            this.xrLabel504.Name = "xrLabel504";
            this.xrLabel504.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel504.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel504.StylePriority.UseBorderDashStyle = false;
            this.xrLabel504.StylePriority.UseBorders = false;
            this.xrLabel504.StylePriority.UsePadding = false;
            // 
            // xrTableCell99
            // 
            this.xrTableCell99.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell99.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel505,
            this.xrLabel506,
            this.xrLabel507,
            this.xrLabel508,
            this.xrLabel509,
            this.xrLabel510});
            this.xrTableCell99.Multiline = true;
            this.xrTableCell99.Name = "xrTableCell99";
            this.xrTableCell99.StylePriority.UseBorders = false;
            this.xrTableCell99.Weight = 0.20290247599283853D;
            // 
            // xrLabel505
            // 
            this.xrLabel505.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel505.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel505.Multiline = true;
            this.xrLabel505.Name = "xrLabel505";
            this.xrLabel505.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel505.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel505.StylePriority.UseBorders = false;
            this.xrLabel505.StylePriority.UsePadding = false;
            // 
            // xrLabel506
            // 
            this.xrLabel506.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel506.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel506.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel506.Multiline = true;
            this.xrLabel506.Name = "xrLabel506";
            this.xrLabel506.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel506.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel506.StylePriority.UseBorderDashStyle = false;
            this.xrLabel506.StylePriority.UseBorders = false;
            this.xrLabel506.StylePriority.UsePadding = false;
            // 
            // xrLabel507
            // 
            this.xrLabel507.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel507.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel507.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel507.Multiline = true;
            this.xrLabel507.Name = "xrLabel507";
            this.xrLabel507.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel507.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel507.StylePriority.UseBorderDashStyle = false;
            this.xrLabel507.StylePriority.UseBorders = false;
            this.xrLabel507.StylePriority.UsePadding = false;
            // 
            // xrLabel508
            // 
            this.xrLabel508.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel508.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel508.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel508.Multiline = true;
            this.xrLabel508.Name = "xrLabel508";
            this.xrLabel508.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel508.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel508.StylePriority.UseBorderDashStyle = false;
            this.xrLabel508.StylePriority.UseBorders = false;
            this.xrLabel508.StylePriority.UsePadding = false;
            // 
            // xrLabel509
            // 
            this.xrLabel509.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel509.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel509.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel509.Multiline = true;
            this.xrLabel509.Name = "xrLabel509";
            this.xrLabel509.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel509.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel509.StylePriority.UseBorderDashStyle = false;
            this.xrLabel509.StylePriority.UseBorders = false;
            this.xrLabel509.StylePriority.UsePadding = false;
            // 
            // xrLabel510
            // 
            this.xrLabel510.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel510.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel510.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel510.Multiline = true;
            this.xrLabel510.Name = "xrLabel510";
            this.xrLabel510.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel510.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel510.StylePriority.UseBorderDashStyle = false;
            this.xrLabel510.StylePriority.UseBorders = false;
            this.xrLabel510.StylePriority.UsePadding = false;
            // 
            // xrTableCell100
            // 
            this.xrTableCell100.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell100.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel511,
            this.xrLabel512,
            this.xrLabel513,
            this.xrLabel514,
            this.xrLabel515,
            this.xrLabel516});
            this.xrTableCell100.Multiline = true;
            this.xrTableCell100.Name = "xrTableCell100";
            this.xrTableCell100.StylePriority.UseBorders = false;
            this.xrTableCell100.Weight = 0.20290247599283853D;
            // 
            // xrLabel511
            // 
            this.xrLabel511.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel511.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel511.Multiline = true;
            this.xrLabel511.Name = "xrLabel511";
            this.xrLabel511.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel511.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel511.StylePriority.UseBorders = false;
            this.xrLabel511.StylePriority.UsePadding = false;
            // 
            // xrLabel512
            // 
            this.xrLabel512.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel512.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel512.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel512.Multiline = true;
            this.xrLabel512.Name = "xrLabel512";
            this.xrLabel512.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel512.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel512.StylePriority.UseBorderDashStyle = false;
            this.xrLabel512.StylePriority.UseBorders = false;
            this.xrLabel512.StylePriority.UsePadding = false;
            // 
            // xrLabel513
            // 
            this.xrLabel513.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel513.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel513.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel513.Multiline = true;
            this.xrLabel513.Name = "xrLabel513";
            this.xrLabel513.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel513.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel513.StylePriority.UseBorderDashStyle = false;
            this.xrLabel513.StylePriority.UseBorders = false;
            this.xrLabel513.StylePriority.UsePadding = false;
            // 
            // xrLabel514
            // 
            this.xrLabel514.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel514.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel514.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel514.Multiline = true;
            this.xrLabel514.Name = "xrLabel514";
            this.xrLabel514.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel514.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel514.StylePriority.UseBorderDashStyle = false;
            this.xrLabel514.StylePriority.UseBorders = false;
            this.xrLabel514.StylePriority.UsePadding = false;
            // 
            // xrLabel515
            // 
            this.xrLabel515.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel515.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel515.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel515.Multiline = true;
            this.xrLabel515.Name = "xrLabel515";
            this.xrLabel515.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel515.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel515.StylePriority.UseBorderDashStyle = false;
            this.xrLabel515.StylePriority.UseBorders = false;
            this.xrLabel515.StylePriority.UsePadding = false;
            // 
            // xrLabel516
            // 
            this.xrLabel516.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel516.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel516.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel516.Multiline = true;
            this.xrLabel516.Name = "xrLabel516";
            this.xrLabel516.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel516.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel516.StylePriority.UseBorderDashStyle = false;
            this.xrLabel516.StylePriority.UseBorders = false;
            this.xrLabel516.StylePriority.UsePadding = false;
            // 
            // xrTableCell101
            // 
            this.xrTableCell101.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell101.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel517,
            this.xrLabel518,
            this.xrLabel519,
            this.xrLabel520,
            this.xrLabel521,
            this.xrLabel522});
            this.xrTableCell101.Multiline = true;
            this.xrTableCell101.Name = "xrTableCell101";
            this.xrTableCell101.StylePriority.UseBorders = false;
            this.xrTableCell101.Weight = 0.20290247599283853D;
            // 
            // xrLabel517
            // 
            this.xrLabel517.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel517.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel517.Multiline = true;
            this.xrLabel517.Name = "xrLabel517";
            this.xrLabel517.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel517.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel517.StylePriority.UseBorders = false;
            this.xrLabel517.StylePriority.UsePadding = false;
            // 
            // xrLabel518
            // 
            this.xrLabel518.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel518.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel518.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel518.Multiline = true;
            this.xrLabel518.Name = "xrLabel518";
            this.xrLabel518.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel518.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel518.StylePriority.UseBorderDashStyle = false;
            this.xrLabel518.StylePriority.UseBorders = false;
            this.xrLabel518.StylePriority.UsePadding = false;
            // 
            // xrLabel519
            // 
            this.xrLabel519.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel519.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel519.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel519.Multiline = true;
            this.xrLabel519.Name = "xrLabel519";
            this.xrLabel519.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel519.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel519.StylePriority.UseBorderDashStyle = false;
            this.xrLabel519.StylePriority.UseBorders = false;
            this.xrLabel519.StylePriority.UsePadding = false;
            // 
            // xrLabel520
            // 
            this.xrLabel520.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel520.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel520.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel520.Multiline = true;
            this.xrLabel520.Name = "xrLabel520";
            this.xrLabel520.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel520.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel520.StylePriority.UseBorderDashStyle = false;
            this.xrLabel520.StylePriority.UseBorders = false;
            this.xrLabel520.StylePriority.UsePadding = false;
            // 
            // xrLabel521
            // 
            this.xrLabel521.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel521.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel521.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel521.Multiline = true;
            this.xrLabel521.Name = "xrLabel521";
            this.xrLabel521.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel521.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel521.StylePriority.UseBorderDashStyle = false;
            this.xrLabel521.StylePriority.UseBorders = false;
            this.xrLabel521.StylePriority.UsePadding = false;
            // 
            // xrLabel522
            // 
            this.xrLabel522.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel522.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel522.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel522.Multiline = true;
            this.xrLabel522.Name = "xrLabel522";
            this.xrLabel522.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel522.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel522.StylePriority.UseBorderDashStyle = false;
            this.xrLabel522.StylePriority.UseBorders = false;
            this.xrLabel522.StylePriority.UsePadding = false;
            // 
            // xrTableCell102
            // 
            this.xrTableCell102.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell102.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel523,
            this.xrLabel524,
            this.xrLabel525,
            this.xrLabel526,
            this.xrLabel527,
            this.xrLabel528});
            this.xrTableCell102.Multiline = true;
            this.xrTableCell102.Name = "xrTableCell102";
            this.xrTableCell102.StylePriority.UseBorders = false;
            this.xrTableCell102.Weight = 0.20290247599283853D;
            // 
            // xrLabel523
            // 
            this.xrLabel523.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel523.LocationFloat = new DevExpress.Utils.PointFloat(0F, 74.99985F);
            this.xrLabel523.Multiline = true;
            this.xrLabel523.Name = "xrLabel523";
            this.xrLabel523.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel523.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel523.StylePriority.UseBorders = false;
            this.xrLabel523.StylePriority.UsePadding = false;
            // 
            // xrLabel524
            // 
            this.xrLabel524.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel524.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel524.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel524.Multiline = true;
            this.xrLabel524.Name = "xrLabel524";
            this.xrLabel524.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel524.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel524.StylePriority.UseBorderDashStyle = false;
            this.xrLabel524.StylePriority.UseBorders = false;
            this.xrLabel524.StylePriority.UsePadding = false;
            // 
            // xrLabel525
            // 
            this.xrLabel525.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel525.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel525.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel525.Multiline = true;
            this.xrLabel525.Name = "xrLabel525";
            this.xrLabel525.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel525.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel525.StylePriority.UseBorderDashStyle = false;
            this.xrLabel525.StylePriority.UseBorders = false;
            this.xrLabel525.StylePriority.UsePadding = false;
            // 
            // xrLabel526
            // 
            this.xrLabel526.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel526.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel526.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel526.Multiline = true;
            this.xrLabel526.Name = "xrLabel526";
            this.xrLabel526.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel526.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel526.StylePriority.UseBorderDashStyle = false;
            this.xrLabel526.StylePriority.UseBorders = false;
            this.xrLabel526.StylePriority.UsePadding = false;
            // 
            // xrLabel527
            // 
            this.xrLabel527.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel527.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel527.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel527.Multiline = true;
            this.xrLabel527.Name = "xrLabel527";
            this.xrLabel527.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel527.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel527.StylePriority.UseBorderDashStyle = false;
            this.xrLabel527.StylePriority.UseBorders = false;
            this.xrLabel527.StylePriority.UsePadding = false;
            // 
            // xrLabel528
            // 
            this.xrLabel528.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel528.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel528.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel528.Multiline = true;
            this.xrLabel528.Name = "xrLabel528";
            this.xrLabel528.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel528.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel528.StylePriority.UseBorderDashStyle = false;
            this.xrLabel528.StylePriority.UseBorders = false;
            this.xrLabel528.StylePriority.UsePadding = false;
            // 
            // xrTable9
            // 
            this.xrTable9.LocationFloat = new DevExpress.Utils.PointFloat(0.0002441406F, 448.3112F);
            this.xrTable9.Name = "xrTable9";
            this.xrTable9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow9});
            this.xrTable9.SizeF = new System.Drawing.SizeF(372.019F, 30.06833F);
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell79,
            this.xrTableCell80,
            this.xrTableCell81,
            this.xrTableCell82,
            this.xrTableCell83,
            this.xrTableCell84,
            this.xrTableCell85,
            this.xrTableCell86,
            this.xrTableCell87,
            this.xrTableCell88,
            this.xrTableCell89,
            this.xrTableCell90});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 1D;
            // 
            // xrTableCell79
            // 
            this.xrTableCell79.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell79.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrLabel432,
            this.xrLabel433});
            this.xrTableCell79.Multiline = true;
            this.xrTableCell79.Name = "xrTableCell79";
            this.xrTableCell79.StylePriority.UseBorders = false;
            this.xrTableCell79.Weight = 0.20290247599283853D;
            this.xrTableCell79.Draw += new DevExpress.XtraReports.UI.DrawEventHandler(this.xrTableCell79_Draw);
            // 
            // xrLine1
            // 
            this.xrLine1.LineDirection = DevExpress.XtraReports.UI.LineDirection.Slant;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3.051758E-05F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(31.00134F, 29.99994F);
            // 
            // xrLabel432
            // 
            this.xrLabel432.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel432.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel432.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel432.Multiline = true;
            this.xrLabel432.Name = "xrLabel432";
            this.xrLabel432.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel432.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel432.StylePriority.UseBorderDashStyle = false;
            this.xrLabel432.StylePriority.UseBorders = false;
            this.xrLabel432.StylePriority.UsePadding = false;
            // 
            // xrLabel433
            // 
            this.xrLabel433.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel433.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel433.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel433.Multiline = true;
            this.xrLabel433.Name = "xrLabel433";
            this.xrLabel433.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel433.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel433.StylePriority.UseBorderDashStyle = false;
            this.xrLabel433.StylePriority.UseBorders = false;
            this.xrLabel433.StylePriority.UsePadding = false;
            // 
            // xrTableCell80
            // 
            this.xrTableCell80.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell80.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2,
            this.xrLabel434,
            this.xrLabel435});
            this.xrTableCell80.Multiline = true;
            this.xrTableCell80.Name = "xrTableCell80";
            this.xrTableCell80.StylePriority.UseBorders = false;
            this.xrTableCell80.Weight = 0.20290247599283853D;
            this.xrTableCell80.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrTableCell79_BeforePrint);
            // 
            // xrLine2
            // 
            this.xrLine2.LineDirection = DevExpress.XtraReports.UI.LineDirection.Slant;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(31.00134F, 29.99994F);
            // 
            // xrLabel434
            // 
            this.xrLabel434.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel434.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel434.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel434.Multiline = true;
            this.xrLabel434.Name = "xrLabel434";
            this.xrLabel434.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel434.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel434.StylePriority.UseBorderDashStyle = false;
            this.xrLabel434.StylePriority.UseBorders = false;
            this.xrLabel434.StylePriority.UsePadding = false;
            // 
            // xrLabel435
            // 
            this.xrLabel435.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel435.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel435.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel435.Multiline = true;
            this.xrLabel435.Name = "xrLabel435";
            this.xrLabel435.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel435.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel435.StylePriority.UseBorderDashStyle = false;
            this.xrLabel435.StylePriority.UseBorders = false;
            this.xrLabel435.StylePriority.UsePadding = false;
            // 
            // xrTableCell81
            // 
            this.xrTableCell81.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell81.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine3,
            this.xrLabel436,
            this.xrLabel437});
            this.xrTableCell81.Multiline = true;
            this.xrTableCell81.Name = "xrTableCell81";
            this.xrTableCell81.StylePriority.UseBorders = false;
            this.xrTableCell81.Weight = 0.20290247599283853D;
            this.xrTableCell81.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrTableCell79_BeforePrint);
            // 
            // xrLine3
            // 
            this.xrLine3.LineDirection = DevExpress.XtraReports.UI.LineDirection.Slant;
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0.0003051758F, 0F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(31.00134F, 29.99994F);
            // 
            // xrLabel436
            // 
            this.xrLabel436.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel436.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel436.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel436.Multiline = true;
            this.xrLabel436.Name = "xrLabel436";
            this.xrLabel436.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel436.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel436.StylePriority.UseBorderDashStyle = false;
            this.xrLabel436.StylePriority.UseBorders = false;
            this.xrLabel436.StylePriority.UsePadding = false;
            // 
            // xrLabel437
            // 
            this.xrLabel437.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel437.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel437.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel437.Multiline = true;
            this.xrLabel437.Name = "xrLabel437";
            this.xrLabel437.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel437.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel437.StylePriority.UseBorderDashStyle = false;
            this.xrLabel437.StylePriority.UseBorders = false;
            this.xrLabel437.StylePriority.UsePadding = false;
            // 
            // xrTableCell82
            // 
            this.xrTableCell82.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell82.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine4,
            this.xrLabel438,
            this.xrLabel439});
            this.xrTableCell82.Multiline = true;
            this.xrTableCell82.Name = "xrTableCell82";
            this.xrTableCell82.StylePriority.UseBorders = false;
            this.xrTableCell82.Weight = 0.20290247599283853D;
            this.xrTableCell82.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrTableCell79_BeforePrint);
            // 
            // xrLine4
            // 
            this.xrLine4.LineDirection = DevExpress.XtraReports.UI.LineDirection.Slant;
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(31.00134F, 29.99994F);
            // 
            // xrLabel438
            // 
            this.xrLabel438.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel438.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel438.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel438.Multiline = true;
            this.xrLabel438.Name = "xrLabel438";
            this.xrLabel438.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel438.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel438.StylePriority.UseBorderDashStyle = false;
            this.xrLabel438.StylePriority.UseBorders = false;
            this.xrLabel438.StylePriority.UsePadding = false;
            // 
            // xrLabel439
            // 
            this.xrLabel439.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel439.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel439.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel439.Multiline = true;
            this.xrLabel439.Name = "xrLabel439";
            this.xrLabel439.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel439.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel439.StylePriority.UseBorderDashStyle = false;
            this.xrLabel439.StylePriority.UseBorders = false;
            this.xrLabel439.StylePriority.UsePadding = false;
            // 
            // xrTableCell83
            // 
            this.xrTableCell83.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell83.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine5,
            this.xrLabel440,
            this.xrLabel441});
            this.xrTableCell83.Multiline = true;
            this.xrTableCell83.Name = "xrTableCell83";
            this.xrTableCell83.StylePriority.UseBorders = false;
            this.xrTableCell83.Weight = 0.20290247599283853D;
            this.xrTableCell83.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrTableCell79_BeforePrint);
            // 
            // xrLine5
            // 
            this.xrLine5.LineDirection = DevExpress.XtraReports.UI.LineDirection.Slant;
            this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(0.0002746582F, 0F);
            this.xrLine5.Name = "xrLine5";
            this.xrLine5.SizeF = new System.Drawing.SizeF(31.00134F, 29.99994F);
            // 
            // xrLabel440
            // 
            this.xrLabel440.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel440.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel440.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel440.Multiline = true;
            this.xrLabel440.Name = "xrLabel440";
            this.xrLabel440.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel440.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel440.StylePriority.UseBorderDashStyle = false;
            this.xrLabel440.StylePriority.UseBorders = false;
            this.xrLabel440.StylePriority.UsePadding = false;
            // 
            // xrLabel441
            // 
            this.xrLabel441.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel441.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel441.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel441.Multiline = true;
            this.xrLabel441.Name = "xrLabel441";
            this.xrLabel441.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel441.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel441.StylePriority.UseBorderDashStyle = false;
            this.xrLabel441.StylePriority.UseBorders = false;
            this.xrLabel441.StylePriority.UsePadding = false;
            // 
            // xrTableCell84
            // 
            this.xrTableCell84.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell84.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine6,
            this.xrLabel442,
            this.xrLabel443});
            this.xrTableCell84.Multiline = true;
            this.xrTableCell84.Name = "xrTableCell84";
            this.xrTableCell84.StylePriority.UseBorders = false;
            this.xrTableCell84.Weight = 0.20290247599283853D;
            this.xrTableCell84.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrTableCell79_BeforePrint);
            // 
            // xrLine6
            // 
            this.xrLine6.LineDirection = DevExpress.XtraReports.UI.LineDirection.Slant;
            this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine6.Name = "xrLine6";
            this.xrLine6.SizeF = new System.Drawing.SizeF(31.00134F, 29.99994F);
            // 
            // xrLabel442
            // 
            this.xrLabel442.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel442.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel442.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel442.Multiline = true;
            this.xrLabel442.Name = "xrLabel442";
            this.xrLabel442.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel442.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel442.StylePriority.UseBorderDashStyle = false;
            this.xrLabel442.StylePriority.UseBorders = false;
            this.xrLabel442.StylePriority.UsePadding = false;
            // 
            // xrLabel443
            // 
            this.xrLabel443.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel443.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel443.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel443.Multiline = true;
            this.xrLabel443.Name = "xrLabel443";
            this.xrLabel443.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel443.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel443.StylePriority.UseBorderDashStyle = false;
            this.xrLabel443.StylePriority.UseBorders = false;
            this.xrLabel443.StylePriority.UsePadding = false;
            // 
            // xrTableCell85
            // 
            this.xrTableCell85.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell85.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine7,
            this.xrLabel444,
            this.xrLabel445});
            this.xrTableCell85.Multiline = true;
            this.xrTableCell85.Name = "xrTableCell85";
            this.xrTableCell85.StylePriority.UseBorders = false;
            this.xrTableCell85.Weight = 0.20290247599283853D;
            this.xrTableCell85.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrTableCell79_BeforePrint);
            // 
            // xrLine7
            // 
            this.xrLine7.LineDirection = DevExpress.XtraReports.UI.LineDirection.Slant;
            this.xrLine7.LocationFloat = new DevExpress.Utils.PointFloat(0.0003356934F, 0F);
            this.xrLine7.Name = "xrLine7";
            this.xrLine7.SizeF = new System.Drawing.SizeF(31.00134F, 29.99994F);
            // 
            // xrLabel444
            // 
            this.xrLabel444.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel444.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel444.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel444.Multiline = true;
            this.xrLabel444.Name = "xrLabel444";
            this.xrLabel444.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel444.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel444.StylePriority.UseBorderDashStyle = false;
            this.xrLabel444.StylePriority.UseBorders = false;
            this.xrLabel444.StylePriority.UsePadding = false;
            // 
            // xrLabel445
            // 
            this.xrLabel445.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel445.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel445.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel445.Multiline = true;
            this.xrLabel445.Name = "xrLabel445";
            this.xrLabel445.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel445.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel445.StylePriority.UseBorderDashStyle = false;
            this.xrLabel445.StylePriority.UseBorders = false;
            this.xrLabel445.StylePriority.UsePadding = false;
            // 
            // xrTableCell86
            // 
            this.xrTableCell86.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell86.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine8,
            this.xrLabel446,
            this.xrLabel447});
            this.xrTableCell86.Multiline = true;
            this.xrTableCell86.Name = "xrTableCell86";
            this.xrTableCell86.StylePriority.UseBorders = false;
            this.xrTableCell86.Weight = 0.20290247599283853D;
            this.xrTableCell86.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrTableCell79_BeforePrint);
            // 
            // xrLine8
            // 
            this.xrLine8.LineDirection = DevExpress.XtraReports.UI.LineDirection.Slant;
            this.xrLine8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine8.Name = "xrLine8";
            this.xrLine8.SizeF = new System.Drawing.SizeF(31.00134F, 29.99994F);
            // 
            // xrLabel446
            // 
            this.xrLabel446.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel446.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel446.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel446.Multiline = true;
            this.xrLabel446.Name = "xrLabel446";
            this.xrLabel446.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel446.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel446.StylePriority.UseBorderDashStyle = false;
            this.xrLabel446.StylePriority.UseBorders = false;
            this.xrLabel446.StylePriority.UsePadding = false;
            // 
            // xrLabel447
            // 
            this.xrLabel447.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel447.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel447.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel447.Multiline = true;
            this.xrLabel447.Name = "xrLabel447";
            this.xrLabel447.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel447.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel447.StylePriority.UseBorderDashStyle = false;
            this.xrLabel447.StylePriority.UseBorders = false;
            this.xrLabel447.StylePriority.UsePadding = false;
            // 
            // xrTableCell87
            // 
            this.xrTableCell87.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell87.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine9,
            this.xrLabel448,
            this.xrLabel449});
            this.xrTableCell87.Multiline = true;
            this.xrTableCell87.Name = "xrTableCell87";
            this.xrTableCell87.StylePriority.UseBorders = false;
            this.xrTableCell87.Weight = 0.20290247599283853D;
            this.xrTableCell87.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrTableCell79_BeforePrint);
            // 
            // xrLine9
            // 
            this.xrLine9.LineDirection = DevExpress.XtraReports.UI.LineDirection.Slant;
            this.xrLine9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine9.Name = "xrLine9";
            this.xrLine9.SizeF = new System.Drawing.SizeF(31.00134F, 29.99994F);
            // 
            // xrLabel448
            // 
            this.xrLabel448.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel448.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel448.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel448.Multiline = true;
            this.xrLabel448.Name = "xrLabel448";
            this.xrLabel448.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel448.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel448.StylePriority.UseBorderDashStyle = false;
            this.xrLabel448.StylePriority.UseBorders = false;
            this.xrLabel448.StylePriority.UsePadding = false;
            // 
            // xrLabel449
            // 
            this.xrLabel449.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel449.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel449.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel449.Multiline = true;
            this.xrLabel449.Name = "xrLabel449";
            this.xrLabel449.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel449.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel449.StylePriority.UseBorderDashStyle = false;
            this.xrLabel449.StylePriority.UseBorders = false;
            this.xrLabel449.StylePriority.UsePadding = false;
            // 
            // xrTableCell88
            // 
            this.xrTableCell88.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell88.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine10,
            this.xrLabel450,
            this.xrLabel451});
            this.xrTableCell88.Multiline = true;
            this.xrTableCell88.Name = "xrTableCell88";
            this.xrTableCell88.StylePriority.UseBorders = false;
            this.xrTableCell88.Weight = 0.20290247599283853D;
            this.xrTableCell88.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrTableCell79_BeforePrint);
            // 
            // xrLine10
            // 
            this.xrLine10.LineDirection = DevExpress.XtraReports.UI.LineDirection.Slant;
            this.xrLine10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine10.Name = "xrLine10";
            this.xrLine10.SizeF = new System.Drawing.SizeF(31.00134F, 29.99994F);
            // 
            // xrLabel450
            // 
            this.xrLabel450.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel450.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel450.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel450.Multiline = true;
            this.xrLabel450.Name = "xrLabel450";
            this.xrLabel450.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel450.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel450.StylePriority.UseBorderDashStyle = false;
            this.xrLabel450.StylePriority.UseBorders = false;
            this.xrLabel450.StylePriority.UsePadding = false;
            // 
            // xrLabel451
            // 
            this.xrLabel451.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel451.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel451.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel451.Multiline = true;
            this.xrLabel451.Name = "xrLabel451";
            this.xrLabel451.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel451.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel451.StylePriority.UseBorderDashStyle = false;
            this.xrLabel451.StylePriority.UseBorders = false;
            this.xrLabel451.StylePriority.UsePadding = false;
            // 
            // xrTableCell89
            // 
            this.xrTableCell89.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell89.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine11,
            this.xrLabel452,
            this.xrLabel453});
            this.xrTableCell89.Multiline = true;
            this.xrTableCell89.Name = "xrTableCell89";
            this.xrTableCell89.StylePriority.UseBorders = false;
            this.xrTableCell89.Weight = 0.20290247599283853D;
            this.xrTableCell89.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrTableCell79_BeforePrint);
            // 
            // xrLine11
            // 
            this.xrLine11.LineDirection = DevExpress.XtraReports.UI.LineDirection.Slant;
            this.xrLine11.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine11.Name = "xrLine11";
            this.xrLine11.SizeF = new System.Drawing.SizeF(31.00134F, 29.99994F);
            // 
            // xrLabel452
            // 
            this.xrLabel452.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel452.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel452.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel452.Multiline = true;
            this.xrLabel452.Name = "xrLabel452";
            this.xrLabel452.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel452.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel452.StylePriority.UseBorderDashStyle = false;
            this.xrLabel452.StylePriority.UseBorders = false;
            this.xrLabel452.StylePriority.UsePadding = false;
            // 
            // xrLabel453
            // 
            this.xrLabel453.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel453.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel453.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel453.Multiline = true;
            this.xrLabel453.Name = "xrLabel453";
            this.xrLabel453.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel453.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel453.StylePriority.UseBorderDashStyle = false;
            this.xrLabel453.StylePriority.UseBorders = false;
            this.xrLabel453.StylePriority.UsePadding = false;
            // 
            // xrTableCell90
            // 
            this.xrTableCell90.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell90.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine12,
            this.xrLabel454,
            this.xrLabel455});
            this.xrTableCell90.Multiline = true;
            this.xrTableCell90.Name = "xrTableCell90";
            this.xrTableCell90.StylePriority.UseBorders = false;
            this.xrTableCell90.Weight = 0.20290247599283853D;
            this.xrTableCell90.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrTableCell79_BeforePrint);
            // 
            // xrLine12
            // 
            this.xrLine12.LineDirection = DevExpress.XtraReports.UI.LineDirection.Slant;
            this.xrLine12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine12.Name = "xrLine12";
            this.xrLine12.SizeF = new System.Drawing.SizeF(31.00134F, 29.99994F);
            // 
            // xrLabel454
            // 
            this.xrLabel454.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel454.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel454.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel454.Multiline = true;
            this.xrLabel454.Name = "xrLabel454";
            this.xrLabel454.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel454.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel454.StylePriority.UseBorderDashStyle = false;
            this.xrLabel454.StylePriority.UseBorders = false;
            this.xrLabel454.StylePriority.UsePadding = false;
            // 
            // xrLabel455
            // 
            this.xrLabel455.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel455.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel455.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel455.Multiline = true;
            this.xrLabel455.Name = "xrLabel455";
            this.xrLabel455.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel455.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel455.StylePriority.UseBorderDashStyle = false;
            this.xrLabel455.StylePriority.UseBorders = false;
            this.xrLabel455.StylePriority.UsePadding = false;
            // 
            // xrTable8
            // 
            this.xrTable8.LocationFloat = new DevExpress.Utils.PointFloat(0.0002746582F, 357.9254F);
            this.xrTable8.Name = "xrTable8";
            this.xrTable8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow8});
            this.xrTable8.SizeF = new System.Drawing.SizeF(372.019F, 90.38583F);
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell67,
            this.xrTableCell68,
            this.xrTableCell69,
            this.xrTableCell70,
            this.xrTableCell71,
            this.xrTableCell72,
            this.xrTableCell73,
            this.xrTableCell74,
            this.xrTableCell75,
            this.xrTableCell76,
            this.xrTableCell77,
            this.xrTableCell78});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1D;
            // 
            // xrTableCell67
            // 
            this.xrTableCell67.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell67.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel329,
            this.xrLabel337,
            this.xrLabel338,
            this.xrLabel339,
            this.xrLabel342,
            this.xrLabel343});
            this.xrTableCell67.Multiline = true;
            this.xrTableCell67.Name = "xrTableCell67";
            this.xrTableCell67.StylePriority.UseBorders = false;
            this.xrTableCell67.Weight = 0.20290247599283853D;
            // 
            // xrLabel329
            // 
            this.xrLabel329.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel329.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel329.Multiline = true;
            this.xrLabel329.Name = "xrLabel329";
            this.xrLabel329.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel329.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel329.StylePriority.UseBorders = false;
            this.xrLabel329.StylePriority.UsePadding = false;
            // 
            // xrLabel337
            // 
            this.xrLabel337.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel337.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel337.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel337.Multiline = true;
            this.xrLabel337.Name = "xrLabel337";
            this.xrLabel337.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel337.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel337.StylePriority.UseBorderDashStyle = false;
            this.xrLabel337.StylePriority.UseBorders = false;
            this.xrLabel337.StylePriority.UsePadding = false;
            // 
            // xrLabel338
            // 
            this.xrLabel338.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel338.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel338.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel338.Multiline = true;
            this.xrLabel338.Name = "xrLabel338";
            this.xrLabel338.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel338.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel338.StylePriority.UseBorderDashStyle = false;
            this.xrLabel338.StylePriority.UseBorders = false;
            this.xrLabel338.StylePriority.UsePadding = false;
            // 
            // xrLabel339
            // 
            this.xrLabel339.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel339.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel339.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel339.Multiline = true;
            this.xrLabel339.Name = "xrLabel339";
            this.xrLabel339.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel339.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel339.StylePriority.UseBorderDashStyle = false;
            this.xrLabel339.StylePriority.UseBorders = false;
            this.xrLabel339.StylePriority.UsePadding = false;
            // 
            // xrLabel342
            // 
            this.xrLabel342.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel342.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel342.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel342.Multiline = true;
            this.xrLabel342.Name = "xrLabel342";
            this.xrLabel342.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel342.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel342.StylePriority.UseBorderDashStyle = false;
            this.xrLabel342.StylePriority.UseBorders = false;
            this.xrLabel342.StylePriority.UsePadding = false;
            // 
            // xrLabel343
            // 
            this.xrLabel343.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel343.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel343.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel343.Multiline = true;
            this.xrLabel343.Name = "xrLabel343";
            this.xrLabel343.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel343.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel343.StylePriority.UseBorderDashStyle = false;
            this.xrLabel343.StylePriority.UseBorders = false;
            this.xrLabel343.StylePriority.UsePadding = false;
            // 
            // xrTableCell68
            // 
            this.xrTableCell68.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell68.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel344,
            this.xrLabel345,
            this.xrLabel348,
            this.xrLabel349,
            this.xrLabel350,
            this.xrLabel351});
            this.xrTableCell68.Multiline = true;
            this.xrTableCell68.Name = "xrTableCell68";
            this.xrTableCell68.StylePriority.UseBorders = false;
            this.xrTableCell68.Weight = 0.20290247599283853D;
            // 
            // xrLabel344
            // 
            this.xrLabel344.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel344.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel344.Multiline = true;
            this.xrLabel344.Name = "xrLabel344";
            this.xrLabel344.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel344.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel344.StylePriority.UseBorders = false;
            this.xrLabel344.StylePriority.UsePadding = false;
            // 
            // xrLabel345
            // 
            this.xrLabel345.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel345.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel345.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel345.Multiline = true;
            this.xrLabel345.Name = "xrLabel345";
            this.xrLabel345.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel345.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel345.StylePriority.UseBorderDashStyle = false;
            this.xrLabel345.StylePriority.UseBorders = false;
            this.xrLabel345.StylePriority.UsePadding = false;
            // 
            // xrLabel348
            // 
            this.xrLabel348.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel348.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel348.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel348.Multiline = true;
            this.xrLabel348.Name = "xrLabel348";
            this.xrLabel348.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel348.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel348.StylePriority.UseBorderDashStyle = false;
            this.xrLabel348.StylePriority.UseBorders = false;
            this.xrLabel348.StylePriority.UsePadding = false;
            // 
            // xrLabel349
            // 
            this.xrLabel349.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel349.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel349.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel349.Multiline = true;
            this.xrLabel349.Name = "xrLabel349";
            this.xrLabel349.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel349.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel349.StylePriority.UseBorderDashStyle = false;
            this.xrLabel349.StylePriority.UseBorders = false;
            this.xrLabel349.StylePriority.UsePadding = false;
            // 
            // xrLabel350
            // 
            this.xrLabel350.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel350.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel350.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel350.Multiline = true;
            this.xrLabel350.Name = "xrLabel350";
            this.xrLabel350.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel350.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel350.StylePriority.UseBorderDashStyle = false;
            this.xrLabel350.StylePriority.UseBorders = false;
            this.xrLabel350.StylePriority.UsePadding = false;
            // 
            // xrLabel351
            // 
            this.xrLabel351.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel351.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel351.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel351.Multiline = true;
            this.xrLabel351.Name = "xrLabel351";
            this.xrLabel351.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel351.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel351.StylePriority.UseBorderDashStyle = false;
            this.xrLabel351.StylePriority.UseBorders = false;
            this.xrLabel351.StylePriority.UsePadding = false;
            // 
            // xrTableCell69
            // 
            this.xrTableCell69.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell69.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel354,
            this.xrLabel355,
            this.xrLabel356,
            this.xrLabel357,
            this.xrLabel360,
            this.xrLabel361});
            this.xrTableCell69.Multiline = true;
            this.xrTableCell69.Name = "xrTableCell69";
            this.xrTableCell69.StylePriority.UseBorders = false;
            this.xrTableCell69.Weight = 0.20290247599283853D;
            // 
            // xrLabel354
            // 
            this.xrLabel354.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel354.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel354.Multiline = true;
            this.xrLabel354.Name = "xrLabel354";
            this.xrLabel354.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel354.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel354.StylePriority.UseBorders = false;
            this.xrLabel354.StylePriority.UsePadding = false;
            // 
            // xrLabel355
            // 
            this.xrLabel355.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel355.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel355.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel355.Multiline = true;
            this.xrLabel355.Name = "xrLabel355";
            this.xrLabel355.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel355.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel355.StylePriority.UseBorderDashStyle = false;
            this.xrLabel355.StylePriority.UseBorders = false;
            this.xrLabel355.StylePriority.UsePadding = false;
            // 
            // xrLabel356
            // 
            this.xrLabel356.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel356.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel356.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel356.Multiline = true;
            this.xrLabel356.Name = "xrLabel356";
            this.xrLabel356.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel356.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel356.StylePriority.UseBorderDashStyle = false;
            this.xrLabel356.StylePriority.UseBorders = false;
            this.xrLabel356.StylePriority.UsePadding = false;
            // 
            // xrLabel357
            // 
            this.xrLabel357.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel357.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel357.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel357.Multiline = true;
            this.xrLabel357.Name = "xrLabel357";
            this.xrLabel357.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel357.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel357.StylePriority.UseBorderDashStyle = false;
            this.xrLabel357.StylePriority.UseBorders = false;
            this.xrLabel357.StylePriority.UsePadding = false;
            // 
            // xrLabel360
            // 
            this.xrLabel360.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel360.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel360.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel360.Multiline = true;
            this.xrLabel360.Name = "xrLabel360";
            this.xrLabel360.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel360.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel360.StylePriority.UseBorderDashStyle = false;
            this.xrLabel360.StylePriority.UseBorders = false;
            this.xrLabel360.StylePriority.UsePadding = false;
            // 
            // xrLabel361
            // 
            this.xrLabel361.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel361.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel361.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel361.Multiline = true;
            this.xrLabel361.Name = "xrLabel361";
            this.xrLabel361.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel361.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel361.StylePriority.UseBorderDashStyle = false;
            this.xrLabel361.StylePriority.UseBorders = false;
            this.xrLabel361.StylePriority.UsePadding = false;
            // 
            // xrTableCell70
            // 
            this.xrTableCell70.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell70.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel362,
            this.xrLabel363,
            this.xrLabel366,
            this.xrLabel367,
            this.xrLabel368,
            this.xrLabel369});
            this.xrTableCell70.Multiline = true;
            this.xrTableCell70.Name = "xrTableCell70";
            this.xrTableCell70.StylePriority.UseBorders = false;
            this.xrTableCell70.Weight = 0.20290247599283853D;
            // 
            // xrLabel362
            // 
            this.xrLabel362.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel362.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel362.Multiline = true;
            this.xrLabel362.Name = "xrLabel362";
            this.xrLabel362.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel362.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel362.StylePriority.UseBorders = false;
            this.xrLabel362.StylePriority.UsePadding = false;
            // 
            // xrLabel363
            // 
            this.xrLabel363.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel363.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel363.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel363.Multiline = true;
            this.xrLabel363.Name = "xrLabel363";
            this.xrLabel363.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel363.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel363.StylePriority.UseBorderDashStyle = false;
            this.xrLabel363.StylePriority.UseBorders = false;
            this.xrLabel363.StylePriority.UsePadding = false;
            // 
            // xrLabel366
            // 
            this.xrLabel366.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel366.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel366.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel366.Multiline = true;
            this.xrLabel366.Name = "xrLabel366";
            this.xrLabel366.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel366.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel366.StylePriority.UseBorderDashStyle = false;
            this.xrLabel366.StylePriority.UseBorders = false;
            this.xrLabel366.StylePriority.UsePadding = false;
            // 
            // xrLabel367
            // 
            this.xrLabel367.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel367.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel367.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel367.Multiline = true;
            this.xrLabel367.Name = "xrLabel367";
            this.xrLabel367.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel367.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel367.StylePriority.UseBorderDashStyle = false;
            this.xrLabel367.StylePriority.UseBorders = false;
            this.xrLabel367.StylePriority.UsePadding = false;
            // 
            // xrLabel368
            // 
            this.xrLabel368.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel368.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel368.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel368.Multiline = true;
            this.xrLabel368.Name = "xrLabel368";
            this.xrLabel368.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel368.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel368.StylePriority.UseBorderDashStyle = false;
            this.xrLabel368.StylePriority.UseBorders = false;
            this.xrLabel368.StylePriority.UsePadding = false;
            // 
            // xrLabel369
            // 
            this.xrLabel369.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel369.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel369.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel369.Multiline = true;
            this.xrLabel369.Name = "xrLabel369";
            this.xrLabel369.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel369.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel369.StylePriority.UseBorderDashStyle = false;
            this.xrLabel369.StylePriority.UseBorders = false;
            this.xrLabel369.StylePriority.UsePadding = false;
            // 
            // xrTableCell71
            // 
            this.xrTableCell71.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell71.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel372,
            this.xrLabel373,
            this.xrLabel374,
            this.xrLabel375,
            this.xrLabel378,
            this.xrLabel379});
            this.xrTableCell71.Multiline = true;
            this.xrTableCell71.Name = "xrTableCell71";
            this.xrTableCell71.StylePriority.UseBorders = false;
            this.xrTableCell71.Weight = 0.20290247599283853D;
            // 
            // xrLabel372
            // 
            this.xrLabel372.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel372.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel372.Multiline = true;
            this.xrLabel372.Name = "xrLabel372";
            this.xrLabel372.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel372.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel372.StylePriority.UseBorders = false;
            this.xrLabel372.StylePriority.UsePadding = false;
            // 
            // xrLabel373
            // 
            this.xrLabel373.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel373.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel373.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel373.Multiline = true;
            this.xrLabel373.Name = "xrLabel373";
            this.xrLabel373.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel373.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel373.StylePriority.UseBorderDashStyle = false;
            this.xrLabel373.StylePriority.UseBorders = false;
            this.xrLabel373.StylePriority.UsePadding = false;
            // 
            // xrLabel374
            // 
            this.xrLabel374.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel374.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel374.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel374.Multiline = true;
            this.xrLabel374.Name = "xrLabel374";
            this.xrLabel374.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel374.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel374.StylePriority.UseBorderDashStyle = false;
            this.xrLabel374.StylePriority.UseBorders = false;
            this.xrLabel374.StylePriority.UsePadding = false;
            // 
            // xrLabel375
            // 
            this.xrLabel375.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel375.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel375.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel375.Multiline = true;
            this.xrLabel375.Name = "xrLabel375";
            this.xrLabel375.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel375.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel375.StylePriority.UseBorderDashStyle = false;
            this.xrLabel375.StylePriority.UseBorders = false;
            this.xrLabel375.StylePriority.UsePadding = false;
            // 
            // xrLabel378
            // 
            this.xrLabel378.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel378.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel378.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel378.Multiline = true;
            this.xrLabel378.Name = "xrLabel378";
            this.xrLabel378.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel378.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel378.StylePriority.UseBorderDashStyle = false;
            this.xrLabel378.StylePriority.UseBorders = false;
            this.xrLabel378.StylePriority.UsePadding = false;
            // 
            // xrLabel379
            // 
            this.xrLabel379.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel379.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel379.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel379.Multiline = true;
            this.xrLabel379.Name = "xrLabel379";
            this.xrLabel379.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel379.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel379.StylePriority.UseBorderDashStyle = false;
            this.xrLabel379.StylePriority.UseBorders = false;
            this.xrLabel379.StylePriority.UsePadding = false;
            // 
            // xrTableCell72
            // 
            this.xrTableCell72.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell72.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel380,
            this.xrLabel381,
            this.xrLabel384,
            this.xrLabel385,
            this.xrLabel386,
            this.xrLabel387});
            this.xrTableCell72.Multiline = true;
            this.xrTableCell72.Name = "xrTableCell72";
            this.xrTableCell72.StylePriority.UseBorders = false;
            this.xrTableCell72.Weight = 0.20290247599283853D;
            // 
            // xrLabel380
            // 
            this.xrLabel380.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel380.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel380.Multiline = true;
            this.xrLabel380.Name = "xrLabel380";
            this.xrLabel380.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel380.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel380.StylePriority.UseBorders = false;
            this.xrLabel380.StylePriority.UsePadding = false;
            // 
            // xrLabel381
            // 
            this.xrLabel381.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel381.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel381.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel381.Multiline = true;
            this.xrLabel381.Name = "xrLabel381";
            this.xrLabel381.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel381.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel381.StylePriority.UseBorderDashStyle = false;
            this.xrLabel381.StylePriority.UseBorders = false;
            this.xrLabel381.StylePriority.UsePadding = false;
            // 
            // xrLabel384
            // 
            this.xrLabel384.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel384.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel384.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel384.Multiline = true;
            this.xrLabel384.Name = "xrLabel384";
            this.xrLabel384.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel384.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel384.StylePriority.UseBorderDashStyle = false;
            this.xrLabel384.StylePriority.UseBorders = false;
            this.xrLabel384.StylePriority.UsePadding = false;
            // 
            // xrLabel385
            // 
            this.xrLabel385.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel385.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel385.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel385.Multiline = true;
            this.xrLabel385.Name = "xrLabel385";
            this.xrLabel385.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel385.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel385.StylePriority.UseBorderDashStyle = false;
            this.xrLabel385.StylePriority.UseBorders = false;
            this.xrLabel385.StylePriority.UsePadding = false;
            // 
            // xrLabel386
            // 
            this.xrLabel386.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel386.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel386.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel386.Multiline = true;
            this.xrLabel386.Name = "xrLabel386";
            this.xrLabel386.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel386.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel386.StylePriority.UseBorderDashStyle = false;
            this.xrLabel386.StylePriority.UseBorders = false;
            this.xrLabel386.StylePriority.UsePadding = false;
            // 
            // xrLabel387
            // 
            this.xrLabel387.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel387.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel387.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel387.Multiline = true;
            this.xrLabel387.Name = "xrLabel387";
            this.xrLabel387.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel387.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel387.StylePriority.UseBorderDashStyle = false;
            this.xrLabel387.StylePriority.UseBorders = false;
            this.xrLabel387.StylePriority.UsePadding = false;
            // 
            // xrTableCell73
            // 
            this.xrTableCell73.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell73.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel390,
            this.xrLabel391,
            this.xrLabel392,
            this.xrLabel393,
            this.xrLabel396,
            this.xrLabel397});
            this.xrTableCell73.Multiline = true;
            this.xrTableCell73.Name = "xrTableCell73";
            this.xrTableCell73.StylePriority.UseBorders = false;
            this.xrTableCell73.Weight = 0.20290247599283853D;
            // 
            // xrLabel390
            // 
            this.xrLabel390.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel390.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel390.Multiline = true;
            this.xrLabel390.Name = "xrLabel390";
            this.xrLabel390.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel390.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel390.StylePriority.UseBorders = false;
            this.xrLabel390.StylePriority.UsePadding = false;
            // 
            // xrLabel391
            // 
            this.xrLabel391.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel391.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel391.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel391.Multiline = true;
            this.xrLabel391.Name = "xrLabel391";
            this.xrLabel391.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel391.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel391.StylePriority.UseBorderDashStyle = false;
            this.xrLabel391.StylePriority.UseBorders = false;
            this.xrLabel391.StylePriority.UsePadding = false;
            // 
            // xrLabel392
            // 
            this.xrLabel392.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel392.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel392.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel392.Multiline = true;
            this.xrLabel392.Name = "xrLabel392";
            this.xrLabel392.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel392.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel392.StylePriority.UseBorderDashStyle = false;
            this.xrLabel392.StylePriority.UseBorders = false;
            this.xrLabel392.StylePriority.UsePadding = false;
            // 
            // xrLabel393
            // 
            this.xrLabel393.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel393.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel393.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel393.Multiline = true;
            this.xrLabel393.Name = "xrLabel393";
            this.xrLabel393.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel393.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel393.StylePriority.UseBorderDashStyle = false;
            this.xrLabel393.StylePriority.UseBorders = false;
            this.xrLabel393.StylePriority.UsePadding = false;
            // 
            // xrLabel396
            // 
            this.xrLabel396.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel396.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel396.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel396.Multiline = true;
            this.xrLabel396.Name = "xrLabel396";
            this.xrLabel396.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel396.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel396.StylePriority.UseBorderDashStyle = false;
            this.xrLabel396.StylePriority.UseBorders = false;
            this.xrLabel396.StylePriority.UsePadding = false;
            // 
            // xrLabel397
            // 
            this.xrLabel397.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel397.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel397.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel397.Multiline = true;
            this.xrLabel397.Name = "xrLabel397";
            this.xrLabel397.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel397.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel397.StylePriority.UseBorderDashStyle = false;
            this.xrLabel397.StylePriority.UseBorders = false;
            this.xrLabel397.StylePriority.UsePadding = false;
            // 
            // xrTableCell74
            // 
            this.xrTableCell74.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell74.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel398,
            this.xrLabel399,
            this.xrLabel402,
            this.xrLabel403,
            this.xrLabel404,
            this.xrLabel405});
            this.xrTableCell74.Multiline = true;
            this.xrTableCell74.Name = "xrTableCell74";
            this.xrTableCell74.StylePriority.UseBorders = false;
            this.xrTableCell74.Weight = 0.20290247599283853D;
            // 
            // xrLabel398
            // 
            this.xrLabel398.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel398.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel398.Multiline = true;
            this.xrLabel398.Name = "xrLabel398";
            this.xrLabel398.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel398.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel398.StylePriority.UseBorders = false;
            this.xrLabel398.StylePriority.UsePadding = false;
            // 
            // xrLabel399
            // 
            this.xrLabel399.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel399.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel399.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel399.Multiline = true;
            this.xrLabel399.Name = "xrLabel399";
            this.xrLabel399.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel399.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel399.StylePriority.UseBorderDashStyle = false;
            this.xrLabel399.StylePriority.UseBorders = false;
            this.xrLabel399.StylePriority.UsePadding = false;
            // 
            // xrLabel402
            // 
            this.xrLabel402.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel402.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel402.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel402.Multiline = true;
            this.xrLabel402.Name = "xrLabel402";
            this.xrLabel402.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel402.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel402.StylePriority.UseBorderDashStyle = false;
            this.xrLabel402.StylePriority.UseBorders = false;
            this.xrLabel402.StylePriority.UsePadding = false;
            // 
            // xrLabel403
            // 
            this.xrLabel403.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel403.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel403.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel403.Multiline = true;
            this.xrLabel403.Name = "xrLabel403";
            this.xrLabel403.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel403.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel403.StylePriority.UseBorderDashStyle = false;
            this.xrLabel403.StylePriority.UseBorders = false;
            this.xrLabel403.StylePriority.UsePadding = false;
            // 
            // xrLabel404
            // 
            this.xrLabel404.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel404.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel404.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel404.Multiline = true;
            this.xrLabel404.Name = "xrLabel404";
            this.xrLabel404.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel404.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel404.StylePriority.UseBorderDashStyle = false;
            this.xrLabel404.StylePriority.UseBorders = false;
            this.xrLabel404.StylePriority.UsePadding = false;
            // 
            // xrLabel405
            // 
            this.xrLabel405.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel405.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel405.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel405.Multiline = true;
            this.xrLabel405.Name = "xrLabel405";
            this.xrLabel405.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel405.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel405.StylePriority.UseBorderDashStyle = false;
            this.xrLabel405.StylePriority.UseBorders = false;
            this.xrLabel405.StylePriority.UsePadding = false;
            // 
            // xrTableCell75
            // 
            this.xrTableCell75.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell75.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel408,
            this.xrLabel409,
            this.xrLabel410,
            this.xrLabel411,
            this.xrLabel412,
            this.xrLabel413});
            this.xrTableCell75.Multiline = true;
            this.xrTableCell75.Name = "xrTableCell75";
            this.xrTableCell75.StylePriority.UseBorders = false;
            this.xrTableCell75.Weight = 0.20290247599283853D;
            // 
            // xrLabel408
            // 
            this.xrLabel408.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel408.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel408.Multiline = true;
            this.xrLabel408.Name = "xrLabel408";
            this.xrLabel408.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel408.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel408.StylePriority.UseBorders = false;
            this.xrLabel408.StylePriority.UsePadding = false;
            // 
            // xrLabel409
            // 
            this.xrLabel409.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel409.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel409.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel409.Multiline = true;
            this.xrLabel409.Name = "xrLabel409";
            this.xrLabel409.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel409.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel409.StylePriority.UseBorderDashStyle = false;
            this.xrLabel409.StylePriority.UseBorders = false;
            this.xrLabel409.StylePriority.UsePadding = false;
            // 
            // xrLabel410
            // 
            this.xrLabel410.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel410.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel410.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel410.Multiline = true;
            this.xrLabel410.Name = "xrLabel410";
            this.xrLabel410.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel410.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel410.StylePriority.UseBorderDashStyle = false;
            this.xrLabel410.StylePriority.UseBorders = false;
            this.xrLabel410.StylePriority.UsePadding = false;
            // 
            // xrLabel411
            // 
            this.xrLabel411.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel411.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel411.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel411.Multiline = true;
            this.xrLabel411.Name = "xrLabel411";
            this.xrLabel411.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel411.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel411.StylePriority.UseBorderDashStyle = false;
            this.xrLabel411.StylePriority.UseBorders = false;
            this.xrLabel411.StylePriority.UsePadding = false;
            // 
            // xrLabel412
            // 
            this.xrLabel412.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel412.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel412.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel412.Multiline = true;
            this.xrLabel412.Name = "xrLabel412";
            this.xrLabel412.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel412.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel412.StylePriority.UseBorderDashStyle = false;
            this.xrLabel412.StylePriority.UseBorders = false;
            this.xrLabel412.StylePriority.UsePadding = false;
            // 
            // xrLabel413
            // 
            this.xrLabel413.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel413.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel413.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel413.Multiline = true;
            this.xrLabel413.Name = "xrLabel413";
            this.xrLabel413.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel413.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel413.StylePriority.UseBorderDashStyle = false;
            this.xrLabel413.StylePriority.UseBorders = false;
            this.xrLabel413.StylePriority.UsePadding = false;
            // 
            // xrTableCell76
            // 
            this.xrTableCell76.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell76.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel414,
            this.xrLabel415,
            this.xrLabel416,
            this.xrLabel417,
            this.xrLabel418,
            this.xrLabel419});
            this.xrTableCell76.Multiline = true;
            this.xrTableCell76.Name = "xrTableCell76";
            this.xrTableCell76.StylePriority.UseBorders = false;
            this.xrTableCell76.Weight = 0.20290247599283853D;
            // 
            // xrLabel414
            // 
            this.xrLabel414.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel414.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel414.Multiline = true;
            this.xrLabel414.Name = "xrLabel414";
            this.xrLabel414.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel414.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel414.StylePriority.UseBorders = false;
            this.xrLabel414.StylePriority.UsePadding = false;
            // 
            // xrLabel415
            // 
            this.xrLabel415.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel415.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel415.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel415.Multiline = true;
            this.xrLabel415.Name = "xrLabel415";
            this.xrLabel415.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel415.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel415.StylePriority.UseBorderDashStyle = false;
            this.xrLabel415.StylePriority.UseBorders = false;
            this.xrLabel415.StylePriority.UsePadding = false;
            // 
            // xrLabel416
            // 
            this.xrLabel416.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel416.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel416.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel416.Multiline = true;
            this.xrLabel416.Name = "xrLabel416";
            this.xrLabel416.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel416.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel416.StylePriority.UseBorderDashStyle = false;
            this.xrLabel416.StylePriority.UseBorders = false;
            this.xrLabel416.StylePriority.UsePadding = false;
            // 
            // xrLabel417
            // 
            this.xrLabel417.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel417.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel417.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel417.Multiline = true;
            this.xrLabel417.Name = "xrLabel417";
            this.xrLabel417.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel417.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel417.StylePriority.UseBorderDashStyle = false;
            this.xrLabel417.StylePriority.UseBorders = false;
            this.xrLabel417.StylePriority.UsePadding = false;
            // 
            // xrLabel418
            // 
            this.xrLabel418.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel418.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel418.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel418.Multiline = true;
            this.xrLabel418.Name = "xrLabel418";
            this.xrLabel418.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel418.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel418.StylePriority.UseBorderDashStyle = false;
            this.xrLabel418.StylePriority.UseBorders = false;
            this.xrLabel418.StylePriority.UsePadding = false;
            // 
            // xrLabel419
            // 
            this.xrLabel419.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel419.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel419.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel419.Multiline = true;
            this.xrLabel419.Name = "xrLabel419";
            this.xrLabel419.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel419.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel419.StylePriority.UseBorderDashStyle = false;
            this.xrLabel419.StylePriority.UseBorders = false;
            this.xrLabel419.StylePriority.UsePadding = false;
            // 
            // xrTableCell77
            // 
            this.xrTableCell77.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell77.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel420,
            this.xrLabel421,
            this.xrLabel422,
            this.xrLabel423,
            this.xrLabel424,
            this.xrLabel425});
            this.xrTableCell77.Multiline = true;
            this.xrTableCell77.Name = "xrTableCell77";
            this.xrTableCell77.StylePriority.UseBorders = false;
            this.xrTableCell77.Weight = 0.20290247599283853D;
            // 
            // xrLabel420
            // 
            this.xrLabel420.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel420.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel420.Multiline = true;
            this.xrLabel420.Name = "xrLabel420";
            this.xrLabel420.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel420.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel420.StylePriority.UseBorders = false;
            this.xrLabel420.StylePriority.UsePadding = false;
            // 
            // xrLabel421
            // 
            this.xrLabel421.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel421.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel421.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel421.Multiline = true;
            this.xrLabel421.Name = "xrLabel421";
            this.xrLabel421.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel421.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel421.StylePriority.UseBorderDashStyle = false;
            this.xrLabel421.StylePriority.UseBorders = false;
            this.xrLabel421.StylePriority.UsePadding = false;
            // 
            // xrLabel422
            // 
            this.xrLabel422.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel422.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel422.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel422.Multiline = true;
            this.xrLabel422.Name = "xrLabel422";
            this.xrLabel422.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel422.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel422.StylePriority.UseBorderDashStyle = false;
            this.xrLabel422.StylePriority.UseBorders = false;
            this.xrLabel422.StylePriority.UsePadding = false;
            // 
            // xrLabel423
            // 
            this.xrLabel423.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel423.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel423.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel423.Multiline = true;
            this.xrLabel423.Name = "xrLabel423";
            this.xrLabel423.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel423.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel423.StylePriority.UseBorderDashStyle = false;
            this.xrLabel423.StylePriority.UseBorders = false;
            this.xrLabel423.StylePriority.UsePadding = false;
            // 
            // xrLabel424
            // 
            this.xrLabel424.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel424.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel424.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel424.Multiline = true;
            this.xrLabel424.Name = "xrLabel424";
            this.xrLabel424.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel424.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel424.StylePriority.UseBorderDashStyle = false;
            this.xrLabel424.StylePriority.UseBorders = false;
            this.xrLabel424.StylePriority.UsePadding = false;
            // 
            // xrLabel425
            // 
            this.xrLabel425.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel425.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel425.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel425.Multiline = true;
            this.xrLabel425.Name = "xrLabel425";
            this.xrLabel425.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel425.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel425.StylePriority.UseBorderDashStyle = false;
            this.xrLabel425.StylePriority.UseBorders = false;
            this.xrLabel425.StylePriority.UsePadding = false;
            // 
            // xrTableCell78
            // 
            this.xrTableCell78.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell78.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel426,
            this.xrLabel427,
            this.xrLabel428,
            this.xrLabel429,
            this.xrLabel430,
            this.xrLabel431});
            this.xrTableCell78.Multiline = true;
            this.xrTableCell78.Name = "xrTableCell78";
            this.xrTableCell78.StylePriority.UseBorders = false;
            this.xrTableCell78.Weight = 0.20290247599283853D;
            // 
            // xrLabel426
            // 
            this.xrLabel426.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel426.LocationFloat = new DevExpress.Utils.PointFloat(0F, 74.99985F);
            this.xrLabel426.Multiline = true;
            this.xrLabel426.Name = "xrLabel426";
            this.xrLabel426.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel426.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel426.StylePriority.UseBorders = false;
            this.xrLabel426.StylePriority.UsePadding = false;
            // 
            // xrLabel427
            // 
            this.xrLabel427.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel427.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel427.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel427.Multiline = true;
            this.xrLabel427.Name = "xrLabel427";
            this.xrLabel427.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel427.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel427.StylePriority.UseBorderDashStyle = false;
            this.xrLabel427.StylePriority.UseBorders = false;
            this.xrLabel427.StylePriority.UsePadding = false;
            // 
            // xrLabel428
            // 
            this.xrLabel428.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel428.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel428.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel428.Multiline = true;
            this.xrLabel428.Name = "xrLabel428";
            this.xrLabel428.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel428.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel428.StylePriority.UseBorderDashStyle = false;
            this.xrLabel428.StylePriority.UseBorders = false;
            this.xrLabel428.StylePriority.UsePadding = false;
            // 
            // xrLabel429
            // 
            this.xrLabel429.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel429.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel429.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel429.Multiline = true;
            this.xrLabel429.Name = "xrLabel429";
            this.xrLabel429.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel429.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel429.StylePriority.UseBorderDashStyle = false;
            this.xrLabel429.StylePriority.UseBorders = false;
            this.xrLabel429.StylePriority.UsePadding = false;
            // 
            // xrLabel430
            // 
            this.xrLabel430.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel430.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel430.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel430.Multiline = true;
            this.xrLabel430.Name = "xrLabel430";
            this.xrLabel430.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel430.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel430.StylePriority.UseBorderDashStyle = false;
            this.xrLabel430.StylePriority.UseBorders = false;
            this.xrLabel430.StylePriority.UsePadding = false;
            // 
            // xrLabel431
            // 
            this.xrLabel431.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel431.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel431.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel431.Multiline = true;
            this.xrLabel431.Name = "xrLabel431";
            this.xrLabel431.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel431.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel431.StylePriority.UseBorderDashStyle = false;
            this.xrLabel431.StylePriority.UseBorders = false;
            this.xrLabel431.StylePriority.UsePadding = false;
            // 
            // xrTable7
            // 
            this.xrTable7.LocationFloat = new DevExpress.Utils.PointFloat(0.000213623F, 327.8571F);
            this.xrTable7.Name = "xrTable7";
            this.xrTable7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7});
            this.xrTable7.SizeF = new System.Drawing.SizeF(372.019F, 30.06833F);
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell55,
            this.xrTableCell56,
            this.xrTableCell57,
            this.xrTableCell58,
            this.xrTableCell59,
            this.xrTableCell60,
            this.xrTableCell61,
            this.xrTableCell62,
            this.xrTableCell63,
            this.xrTableCell64,
            this.xrTableCell65,
            this.xrTableCell66});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // xrTableCell55
            // 
            this.xrTableCell55.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell55.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel340,
            this.xrLabel341});
            this.xrTableCell55.Multiline = true;
            this.xrTableCell55.Name = "xrTableCell55";
            this.xrTableCell55.StylePriority.UseBorders = false;
            this.xrTableCell55.Weight = 0.20290247599283853D;
            // 
            // xrLabel340
            // 
            this.xrLabel340.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel340.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel340.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel340.Multiline = true;
            this.xrLabel340.Name = "xrLabel340";
            this.xrLabel340.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel340.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel340.StylePriority.UseBorderDashStyle = false;
            this.xrLabel340.StylePriority.UseBorders = false;
            this.xrLabel340.StylePriority.UsePadding = false;
            // 
            // xrLabel341
            // 
            this.xrLabel341.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel341.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel341.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel341.Multiline = true;
            this.xrLabel341.Name = "xrLabel341";
            this.xrLabel341.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel341.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel341.StylePriority.UseBorderDashStyle = false;
            this.xrLabel341.StylePriority.UseBorders = false;
            this.xrLabel341.StylePriority.UsePadding = false;
            // 
            // xrTableCell56
            // 
            this.xrTableCell56.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell56.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel346,
            this.xrLabel347});
            this.xrTableCell56.Multiline = true;
            this.xrTableCell56.Name = "xrTableCell56";
            this.xrTableCell56.StylePriority.UseBorders = false;
            this.xrTableCell56.Weight = 0.20290247599283853D;
            // 
            // xrLabel346
            // 
            this.xrLabel346.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel346.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel346.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel346.Multiline = true;
            this.xrLabel346.Name = "xrLabel346";
            this.xrLabel346.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel346.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel346.StylePriority.UseBorderDashStyle = false;
            this.xrLabel346.StylePriority.UseBorders = false;
            this.xrLabel346.StylePriority.UsePadding = false;
            // 
            // xrLabel347
            // 
            this.xrLabel347.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel347.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel347.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel347.Multiline = true;
            this.xrLabel347.Name = "xrLabel347";
            this.xrLabel347.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel347.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel347.StylePriority.UseBorderDashStyle = false;
            this.xrLabel347.StylePriority.UseBorders = false;
            this.xrLabel347.StylePriority.UsePadding = false;
            // 
            // xrTableCell57
            // 
            this.xrTableCell57.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell57.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel352,
            this.xrLabel353});
            this.xrTableCell57.Multiline = true;
            this.xrTableCell57.Name = "xrTableCell57";
            this.xrTableCell57.StylePriority.UseBorders = false;
            this.xrTableCell57.Weight = 0.20290247599283853D;
            // 
            // xrLabel352
            // 
            this.xrLabel352.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel352.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel352.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel352.Multiline = true;
            this.xrLabel352.Name = "xrLabel352";
            this.xrLabel352.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel352.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel352.StylePriority.UseBorderDashStyle = false;
            this.xrLabel352.StylePriority.UseBorders = false;
            this.xrLabel352.StylePriority.UsePadding = false;
            // 
            // xrLabel353
            // 
            this.xrLabel353.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel353.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel353.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel353.Multiline = true;
            this.xrLabel353.Name = "xrLabel353";
            this.xrLabel353.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel353.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel353.StylePriority.UseBorderDashStyle = false;
            this.xrLabel353.StylePriority.UseBorders = false;
            this.xrLabel353.StylePriority.UsePadding = false;
            // 
            // xrTableCell58
            // 
            this.xrTableCell58.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell58.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel358,
            this.xrLabel359});
            this.xrTableCell58.Multiline = true;
            this.xrTableCell58.Name = "xrTableCell58";
            this.xrTableCell58.StylePriority.UseBorders = false;
            this.xrTableCell58.Weight = 0.20290247599283853D;
            // 
            // xrLabel358
            // 
            this.xrLabel358.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel358.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel358.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel358.Multiline = true;
            this.xrLabel358.Name = "xrLabel358";
            this.xrLabel358.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel358.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel358.StylePriority.UseBorderDashStyle = false;
            this.xrLabel358.StylePriority.UseBorders = false;
            this.xrLabel358.StylePriority.UsePadding = false;
            // 
            // xrLabel359
            // 
            this.xrLabel359.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel359.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel359.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel359.Multiline = true;
            this.xrLabel359.Name = "xrLabel359";
            this.xrLabel359.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel359.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel359.StylePriority.UseBorderDashStyle = false;
            this.xrLabel359.StylePriority.UseBorders = false;
            this.xrLabel359.StylePriority.UsePadding = false;
            // 
            // xrTableCell59
            // 
            this.xrTableCell59.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell59.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel364,
            this.xrLabel365});
            this.xrTableCell59.Multiline = true;
            this.xrTableCell59.Name = "xrTableCell59";
            this.xrTableCell59.StylePriority.UseBorders = false;
            this.xrTableCell59.Weight = 0.20290247599283853D;
            // 
            // xrLabel364
            // 
            this.xrLabel364.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel364.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel364.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel364.Multiline = true;
            this.xrLabel364.Name = "xrLabel364";
            this.xrLabel364.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel364.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel364.StylePriority.UseBorderDashStyle = false;
            this.xrLabel364.StylePriority.UseBorders = false;
            this.xrLabel364.StylePriority.UsePadding = false;
            // 
            // xrLabel365
            // 
            this.xrLabel365.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel365.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel365.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel365.Multiline = true;
            this.xrLabel365.Name = "xrLabel365";
            this.xrLabel365.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel365.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel365.StylePriority.UseBorderDashStyle = false;
            this.xrLabel365.StylePriority.UseBorders = false;
            this.xrLabel365.StylePriority.UsePadding = false;
            // 
            // xrTableCell60
            // 
            this.xrTableCell60.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell60.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel370,
            this.xrLabel371});
            this.xrTableCell60.Multiline = true;
            this.xrTableCell60.Name = "xrTableCell60";
            this.xrTableCell60.StylePriority.UseBorders = false;
            this.xrTableCell60.Weight = 0.20290247599283853D;
            // 
            // xrLabel370
            // 
            this.xrLabel370.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel370.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel370.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel370.Multiline = true;
            this.xrLabel370.Name = "xrLabel370";
            this.xrLabel370.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel370.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel370.StylePriority.UseBorderDashStyle = false;
            this.xrLabel370.StylePriority.UseBorders = false;
            this.xrLabel370.StylePriority.UsePadding = false;
            // 
            // xrLabel371
            // 
            this.xrLabel371.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel371.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel371.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel371.Multiline = true;
            this.xrLabel371.Name = "xrLabel371";
            this.xrLabel371.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel371.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel371.StylePriority.UseBorderDashStyle = false;
            this.xrLabel371.StylePriority.UseBorders = false;
            this.xrLabel371.StylePriority.UsePadding = false;
            // 
            // xrTableCell61
            // 
            this.xrTableCell61.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell61.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel376,
            this.xrLabel377});
            this.xrTableCell61.Multiline = true;
            this.xrTableCell61.Name = "xrTableCell61";
            this.xrTableCell61.StylePriority.UseBorders = false;
            this.xrTableCell61.Weight = 0.20290247599283853D;
            // 
            // xrLabel376
            // 
            this.xrLabel376.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel376.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel376.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel376.Multiline = true;
            this.xrLabel376.Name = "xrLabel376";
            this.xrLabel376.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel376.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel376.StylePriority.UseBorderDashStyle = false;
            this.xrLabel376.StylePriority.UseBorders = false;
            this.xrLabel376.StylePriority.UsePadding = false;
            // 
            // xrLabel377
            // 
            this.xrLabel377.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel377.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel377.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel377.Multiline = true;
            this.xrLabel377.Name = "xrLabel377";
            this.xrLabel377.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel377.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel377.StylePriority.UseBorderDashStyle = false;
            this.xrLabel377.StylePriority.UseBorders = false;
            this.xrLabel377.StylePriority.UsePadding = false;
            // 
            // xrTableCell62
            // 
            this.xrTableCell62.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell62.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel382,
            this.xrLabel383});
            this.xrTableCell62.Multiline = true;
            this.xrTableCell62.Name = "xrTableCell62";
            this.xrTableCell62.StylePriority.UseBorders = false;
            this.xrTableCell62.Weight = 0.20290247599283853D;
            // 
            // xrLabel382
            // 
            this.xrLabel382.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel382.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel382.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel382.Multiline = true;
            this.xrLabel382.Name = "xrLabel382";
            this.xrLabel382.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel382.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel382.StylePriority.UseBorderDashStyle = false;
            this.xrLabel382.StylePriority.UseBorders = false;
            this.xrLabel382.StylePriority.UsePadding = false;
            // 
            // xrLabel383
            // 
            this.xrLabel383.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel383.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel383.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel383.Multiline = true;
            this.xrLabel383.Name = "xrLabel383";
            this.xrLabel383.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel383.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel383.StylePriority.UseBorderDashStyle = false;
            this.xrLabel383.StylePriority.UseBorders = false;
            this.xrLabel383.StylePriority.UsePadding = false;
            // 
            // xrTableCell63
            // 
            this.xrTableCell63.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell63.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel388,
            this.xrLabel389});
            this.xrTableCell63.Multiline = true;
            this.xrTableCell63.Name = "xrTableCell63";
            this.xrTableCell63.StylePriority.UseBorders = false;
            this.xrTableCell63.Weight = 0.20290247599283853D;
            // 
            // xrLabel388
            // 
            this.xrLabel388.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel388.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel388.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel388.Multiline = true;
            this.xrLabel388.Name = "xrLabel388";
            this.xrLabel388.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel388.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel388.StylePriority.UseBorderDashStyle = false;
            this.xrLabel388.StylePriority.UseBorders = false;
            this.xrLabel388.StylePriority.UsePadding = false;
            // 
            // xrLabel389
            // 
            this.xrLabel389.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel389.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel389.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel389.Multiline = true;
            this.xrLabel389.Name = "xrLabel389";
            this.xrLabel389.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel389.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel389.StylePriority.UseBorderDashStyle = false;
            this.xrLabel389.StylePriority.UseBorders = false;
            this.xrLabel389.StylePriority.UsePadding = false;
            // 
            // xrTableCell64
            // 
            this.xrTableCell64.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell64.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel394,
            this.xrLabel395});
            this.xrTableCell64.Multiline = true;
            this.xrTableCell64.Name = "xrTableCell64";
            this.xrTableCell64.StylePriority.UseBorders = false;
            this.xrTableCell64.Weight = 0.20290247599283853D;
            // 
            // xrLabel394
            // 
            this.xrLabel394.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel394.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel394.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel394.Multiline = true;
            this.xrLabel394.Name = "xrLabel394";
            this.xrLabel394.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel394.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel394.StylePriority.UseBorderDashStyle = false;
            this.xrLabel394.StylePriority.UseBorders = false;
            this.xrLabel394.StylePriority.UsePadding = false;
            // 
            // xrLabel395
            // 
            this.xrLabel395.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel395.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel395.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel395.Multiline = true;
            this.xrLabel395.Name = "xrLabel395";
            this.xrLabel395.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel395.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel395.StylePriority.UseBorderDashStyle = false;
            this.xrLabel395.StylePriority.UseBorders = false;
            this.xrLabel395.StylePriority.UsePadding = false;
            // 
            // xrTableCell65
            // 
            this.xrTableCell65.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell65.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel400,
            this.xrLabel401});
            this.xrTableCell65.Multiline = true;
            this.xrTableCell65.Name = "xrTableCell65";
            this.xrTableCell65.StylePriority.UseBorders = false;
            this.xrTableCell65.Weight = 0.20290247599283853D;
            // 
            // xrLabel400
            // 
            this.xrLabel400.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel400.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel400.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel400.Multiline = true;
            this.xrLabel400.Name = "xrLabel400";
            this.xrLabel400.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel400.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel400.StylePriority.UseBorderDashStyle = false;
            this.xrLabel400.StylePriority.UseBorders = false;
            this.xrLabel400.StylePriority.UsePadding = false;
            // 
            // xrLabel401
            // 
            this.xrLabel401.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel401.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel401.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel401.Multiline = true;
            this.xrLabel401.Name = "xrLabel401";
            this.xrLabel401.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel401.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel401.StylePriority.UseBorderDashStyle = false;
            this.xrLabel401.StylePriority.UseBorders = false;
            this.xrLabel401.StylePriority.UsePadding = false;
            // 
            // xrTableCell66
            // 
            this.xrTableCell66.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell66.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel406,
            this.xrLabel407});
            this.xrTableCell66.Multiline = true;
            this.xrTableCell66.Name = "xrTableCell66";
            this.xrTableCell66.StylePriority.UseBorders = false;
            this.xrTableCell66.Weight = 0.20290247599283853D;
            // 
            // xrLabel406
            // 
            this.xrLabel406.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel406.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel406.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel406.Multiline = true;
            this.xrLabel406.Name = "xrLabel406";
            this.xrLabel406.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel406.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel406.StylePriority.UseBorderDashStyle = false;
            this.xrLabel406.StylePriority.UseBorders = false;
            this.xrLabel406.StylePriority.UsePadding = false;
            // 
            // xrLabel407
            // 
            this.xrLabel407.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel407.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel407.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel407.Multiline = true;
            this.xrLabel407.Name = "xrLabel407";
            this.xrLabel407.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel407.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel407.StylePriority.UseBorderDashStyle = false;
            this.xrLabel407.StylePriority.UseBorders = false;
            this.xrLabel407.StylePriority.UsePadding = false;
            // 
            // xrTable6
            // 
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(0.0001525879F, 237.4713F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6});
            this.xrTable6.SizeF = new System.Drawing.SizeF(372.019F, 90.38583F);
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell43,
            this.xrTableCell44,
            this.xrTableCell45,
            this.xrTableCell46,
            this.xrTableCell47,
            this.xrTableCell48,
            this.xrTableCell49,
            this.xrTableCell50,
            this.xrTableCell51,
            this.xrTableCell52,
            this.xrTableCell53,
            this.xrTableCell54});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // xrTableCell43
            // 
            this.xrTableCell43.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell43.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel295,
            this.xrLabel235,
            this.xrLabel236,
            this.xrLabel237,
            this.xrLabel238,
            this.xrLabel239});
            this.xrTableCell43.Multiline = true;
            this.xrTableCell43.Name = "xrTableCell43";
            this.xrTableCell43.StylePriority.UseBorders = false;
            this.xrTableCell43.Weight = 0.20290247599283853D;
            // 
            // xrLabel295
            // 
            this.xrLabel295.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel295.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel295.Multiline = true;
            this.xrLabel295.Name = "xrLabel295";
            this.xrLabel295.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel295.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel295.StylePriority.UseBorders = false;
            this.xrLabel295.StylePriority.UsePadding = false;
            // 
            // xrLabel235
            // 
            this.xrLabel235.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel235.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel235.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel235.Multiline = true;
            this.xrLabel235.Name = "xrLabel235";
            this.xrLabel235.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel235.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel235.StylePriority.UseBorderDashStyle = false;
            this.xrLabel235.StylePriority.UseBorders = false;
            this.xrLabel235.StylePriority.UsePadding = false;
            // 
            // xrLabel236
            // 
            this.xrLabel236.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel236.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel236.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel236.Multiline = true;
            this.xrLabel236.Name = "xrLabel236";
            this.xrLabel236.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel236.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel236.StylePriority.UseBorderDashStyle = false;
            this.xrLabel236.StylePriority.UseBorders = false;
            this.xrLabel236.StylePriority.UsePadding = false;
            // 
            // xrLabel237
            // 
            this.xrLabel237.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel237.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel237.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel237.Multiline = true;
            this.xrLabel237.Name = "xrLabel237";
            this.xrLabel237.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel237.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel237.StylePriority.UseBorderDashStyle = false;
            this.xrLabel237.StylePriority.UseBorders = false;
            this.xrLabel237.StylePriority.UsePadding = false;
            // 
            // xrLabel238
            // 
            this.xrLabel238.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel238.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel238.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel238.Multiline = true;
            this.xrLabel238.Name = "xrLabel238";
            this.xrLabel238.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel238.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel238.StylePriority.UseBorderDashStyle = false;
            this.xrLabel238.StylePriority.UseBorders = false;
            this.xrLabel238.StylePriority.UsePadding = false;
            // 
            // xrLabel239
            // 
            this.xrLabel239.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel239.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel239.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel239.Multiline = true;
            this.xrLabel239.Name = "xrLabel239";
            this.xrLabel239.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel239.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel239.StylePriority.UseBorderDashStyle = false;
            this.xrLabel239.StylePriority.UseBorders = false;
            this.xrLabel239.StylePriority.UsePadding = false;
            // 
            // xrTableCell44
            // 
            this.xrTableCell44.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell44.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel296,
            this.xrLabel240,
            this.xrLabel241,
            this.xrLabel242,
            this.xrLabel243,
            this.xrLabel244});
            this.xrTableCell44.Multiline = true;
            this.xrTableCell44.Name = "xrTableCell44";
            this.xrTableCell44.StylePriority.UseBorders = false;
            this.xrTableCell44.Weight = 0.20290247599283853D;
            // 
            // xrLabel296
            // 
            this.xrLabel296.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel296.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel296.Multiline = true;
            this.xrLabel296.Name = "xrLabel296";
            this.xrLabel296.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel296.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel296.StylePriority.UseBorders = false;
            this.xrLabel296.StylePriority.UsePadding = false;
            // 
            // xrLabel240
            // 
            this.xrLabel240.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel240.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel240.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel240.Multiline = true;
            this.xrLabel240.Name = "xrLabel240";
            this.xrLabel240.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel240.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel240.StylePriority.UseBorderDashStyle = false;
            this.xrLabel240.StylePriority.UseBorders = false;
            this.xrLabel240.StylePriority.UsePadding = false;
            // 
            // xrLabel241
            // 
            this.xrLabel241.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel241.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel241.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel241.Multiline = true;
            this.xrLabel241.Name = "xrLabel241";
            this.xrLabel241.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel241.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel241.StylePriority.UseBorderDashStyle = false;
            this.xrLabel241.StylePriority.UseBorders = false;
            this.xrLabel241.StylePriority.UsePadding = false;
            // 
            // xrLabel242
            // 
            this.xrLabel242.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel242.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel242.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel242.Multiline = true;
            this.xrLabel242.Name = "xrLabel242";
            this.xrLabel242.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel242.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel242.StylePriority.UseBorderDashStyle = false;
            this.xrLabel242.StylePriority.UseBorders = false;
            this.xrLabel242.StylePriority.UsePadding = false;
            // 
            // xrLabel243
            // 
            this.xrLabel243.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel243.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel243.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel243.Multiline = true;
            this.xrLabel243.Name = "xrLabel243";
            this.xrLabel243.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel243.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel243.StylePriority.UseBorderDashStyle = false;
            this.xrLabel243.StylePriority.UseBorders = false;
            this.xrLabel243.StylePriority.UsePadding = false;
            // 
            // xrLabel244
            // 
            this.xrLabel244.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel244.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel244.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel244.Multiline = true;
            this.xrLabel244.Name = "xrLabel244";
            this.xrLabel244.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel244.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel244.StylePriority.UseBorderDashStyle = false;
            this.xrLabel244.StylePriority.UseBorders = false;
            this.xrLabel244.StylePriority.UsePadding = false;
            // 
            // xrTableCell45
            // 
            this.xrTableCell45.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell45.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel297,
            this.xrLabel245,
            this.xrLabel246,
            this.xrLabel247,
            this.xrLabel248,
            this.xrLabel249});
            this.xrTableCell45.Multiline = true;
            this.xrTableCell45.Name = "xrTableCell45";
            this.xrTableCell45.StylePriority.UseBorders = false;
            this.xrTableCell45.Weight = 0.20290247599283853D;
            // 
            // xrLabel297
            // 
            this.xrLabel297.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel297.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel297.Multiline = true;
            this.xrLabel297.Name = "xrLabel297";
            this.xrLabel297.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel297.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel297.StylePriority.UseBorders = false;
            this.xrLabel297.StylePriority.UsePadding = false;
            // 
            // xrLabel245
            // 
            this.xrLabel245.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel245.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel245.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel245.Multiline = true;
            this.xrLabel245.Name = "xrLabel245";
            this.xrLabel245.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel245.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel245.StylePriority.UseBorderDashStyle = false;
            this.xrLabel245.StylePriority.UseBorders = false;
            this.xrLabel245.StylePriority.UsePadding = false;
            // 
            // xrLabel246
            // 
            this.xrLabel246.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel246.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel246.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel246.Multiline = true;
            this.xrLabel246.Name = "xrLabel246";
            this.xrLabel246.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel246.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel246.StylePriority.UseBorderDashStyle = false;
            this.xrLabel246.StylePriority.UseBorders = false;
            this.xrLabel246.StylePriority.UsePadding = false;
            // 
            // xrLabel247
            // 
            this.xrLabel247.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel247.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel247.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel247.Multiline = true;
            this.xrLabel247.Name = "xrLabel247";
            this.xrLabel247.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel247.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel247.StylePriority.UseBorderDashStyle = false;
            this.xrLabel247.StylePriority.UseBorders = false;
            this.xrLabel247.StylePriority.UsePadding = false;
            // 
            // xrLabel248
            // 
            this.xrLabel248.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel248.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel248.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel248.Multiline = true;
            this.xrLabel248.Name = "xrLabel248";
            this.xrLabel248.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel248.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel248.StylePriority.UseBorderDashStyle = false;
            this.xrLabel248.StylePriority.UseBorders = false;
            this.xrLabel248.StylePriority.UsePadding = false;
            // 
            // xrLabel249
            // 
            this.xrLabel249.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel249.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel249.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel249.Multiline = true;
            this.xrLabel249.Name = "xrLabel249";
            this.xrLabel249.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel249.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel249.StylePriority.UseBorderDashStyle = false;
            this.xrLabel249.StylePriority.UseBorders = false;
            this.xrLabel249.StylePriority.UsePadding = false;
            // 
            // xrTableCell46
            // 
            this.xrTableCell46.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell46.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel298,
            this.xrLabel250,
            this.xrLabel251,
            this.xrLabel252,
            this.xrLabel253,
            this.xrLabel254});
            this.xrTableCell46.Multiline = true;
            this.xrTableCell46.Name = "xrTableCell46";
            this.xrTableCell46.StylePriority.UseBorders = false;
            this.xrTableCell46.Weight = 0.20290247599283853D;
            // 
            // xrLabel298
            // 
            this.xrLabel298.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel298.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel298.Multiline = true;
            this.xrLabel298.Name = "xrLabel298";
            this.xrLabel298.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel298.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel298.StylePriority.UseBorders = false;
            this.xrLabel298.StylePriority.UsePadding = false;
            // 
            // xrLabel250
            // 
            this.xrLabel250.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel250.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel250.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel250.Multiline = true;
            this.xrLabel250.Name = "xrLabel250";
            this.xrLabel250.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel250.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel250.StylePriority.UseBorderDashStyle = false;
            this.xrLabel250.StylePriority.UseBorders = false;
            this.xrLabel250.StylePriority.UsePadding = false;
            // 
            // xrLabel251
            // 
            this.xrLabel251.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel251.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel251.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel251.Multiline = true;
            this.xrLabel251.Name = "xrLabel251";
            this.xrLabel251.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel251.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel251.StylePriority.UseBorderDashStyle = false;
            this.xrLabel251.StylePriority.UseBorders = false;
            this.xrLabel251.StylePriority.UsePadding = false;
            // 
            // xrLabel252
            // 
            this.xrLabel252.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel252.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel252.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel252.Multiline = true;
            this.xrLabel252.Name = "xrLabel252";
            this.xrLabel252.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel252.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel252.StylePriority.UseBorderDashStyle = false;
            this.xrLabel252.StylePriority.UseBorders = false;
            this.xrLabel252.StylePriority.UsePadding = false;
            // 
            // xrLabel253
            // 
            this.xrLabel253.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel253.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel253.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel253.Multiline = true;
            this.xrLabel253.Name = "xrLabel253";
            this.xrLabel253.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel253.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel253.StylePriority.UseBorderDashStyle = false;
            this.xrLabel253.StylePriority.UseBorders = false;
            this.xrLabel253.StylePriority.UsePadding = false;
            // 
            // xrLabel254
            // 
            this.xrLabel254.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel254.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel254.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel254.Multiline = true;
            this.xrLabel254.Name = "xrLabel254";
            this.xrLabel254.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel254.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel254.StylePriority.UseBorderDashStyle = false;
            this.xrLabel254.StylePriority.UseBorders = false;
            this.xrLabel254.StylePriority.UsePadding = false;
            // 
            // xrTableCell47
            // 
            this.xrTableCell47.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell47.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel299,
            this.xrLabel255,
            this.xrLabel256,
            this.xrLabel257,
            this.xrLabel258,
            this.xrLabel259});
            this.xrTableCell47.Multiline = true;
            this.xrTableCell47.Name = "xrTableCell47";
            this.xrTableCell47.StylePriority.UseBorders = false;
            this.xrTableCell47.Weight = 0.20290247599283853D;
            // 
            // xrLabel299
            // 
            this.xrLabel299.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel299.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel299.Multiline = true;
            this.xrLabel299.Name = "xrLabel299";
            this.xrLabel299.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel299.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel299.StylePriority.UseBorders = false;
            this.xrLabel299.StylePriority.UsePadding = false;
            // 
            // xrLabel255
            // 
            this.xrLabel255.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel255.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel255.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel255.Multiline = true;
            this.xrLabel255.Name = "xrLabel255";
            this.xrLabel255.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel255.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel255.StylePriority.UseBorderDashStyle = false;
            this.xrLabel255.StylePriority.UseBorders = false;
            this.xrLabel255.StylePriority.UsePadding = false;
            // 
            // xrLabel256
            // 
            this.xrLabel256.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel256.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel256.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel256.Multiline = true;
            this.xrLabel256.Name = "xrLabel256";
            this.xrLabel256.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel256.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel256.StylePriority.UseBorderDashStyle = false;
            this.xrLabel256.StylePriority.UseBorders = false;
            this.xrLabel256.StylePriority.UsePadding = false;
            // 
            // xrLabel257
            // 
            this.xrLabel257.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel257.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel257.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel257.Multiline = true;
            this.xrLabel257.Name = "xrLabel257";
            this.xrLabel257.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel257.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel257.StylePriority.UseBorderDashStyle = false;
            this.xrLabel257.StylePriority.UseBorders = false;
            this.xrLabel257.StylePriority.UsePadding = false;
            // 
            // xrLabel258
            // 
            this.xrLabel258.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel258.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel258.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel258.Multiline = true;
            this.xrLabel258.Name = "xrLabel258";
            this.xrLabel258.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel258.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel258.StylePriority.UseBorderDashStyle = false;
            this.xrLabel258.StylePriority.UseBorders = false;
            this.xrLabel258.StylePriority.UsePadding = false;
            // 
            // xrLabel259
            // 
            this.xrLabel259.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel259.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel259.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel259.Multiline = true;
            this.xrLabel259.Name = "xrLabel259";
            this.xrLabel259.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel259.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel259.StylePriority.UseBorderDashStyle = false;
            this.xrLabel259.StylePriority.UseBorders = false;
            this.xrLabel259.StylePriority.UsePadding = false;
            // 
            // xrTableCell48
            // 
            this.xrTableCell48.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell48.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel300,
            this.xrLabel260,
            this.xrLabel261,
            this.xrLabel262,
            this.xrLabel263,
            this.xrLabel264});
            this.xrTableCell48.Multiline = true;
            this.xrTableCell48.Name = "xrTableCell48";
            this.xrTableCell48.StylePriority.UseBorders = false;
            this.xrTableCell48.Weight = 0.20290247599283853D;
            // 
            // xrLabel300
            // 
            this.xrLabel300.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel300.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel300.Multiline = true;
            this.xrLabel300.Name = "xrLabel300";
            this.xrLabel300.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel300.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel300.StylePriority.UseBorders = false;
            this.xrLabel300.StylePriority.UsePadding = false;
            // 
            // xrLabel260
            // 
            this.xrLabel260.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel260.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel260.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel260.Multiline = true;
            this.xrLabel260.Name = "xrLabel260";
            this.xrLabel260.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel260.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel260.StylePriority.UseBorderDashStyle = false;
            this.xrLabel260.StylePriority.UseBorders = false;
            this.xrLabel260.StylePriority.UsePadding = false;
            // 
            // xrLabel261
            // 
            this.xrLabel261.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel261.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel261.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel261.Multiline = true;
            this.xrLabel261.Name = "xrLabel261";
            this.xrLabel261.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel261.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel261.StylePriority.UseBorderDashStyle = false;
            this.xrLabel261.StylePriority.UseBorders = false;
            this.xrLabel261.StylePriority.UsePadding = false;
            // 
            // xrLabel262
            // 
            this.xrLabel262.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel262.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel262.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel262.Multiline = true;
            this.xrLabel262.Name = "xrLabel262";
            this.xrLabel262.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel262.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel262.StylePriority.UseBorderDashStyle = false;
            this.xrLabel262.StylePriority.UseBorders = false;
            this.xrLabel262.StylePriority.UsePadding = false;
            // 
            // xrLabel263
            // 
            this.xrLabel263.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel263.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel263.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel263.Multiline = true;
            this.xrLabel263.Name = "xrLabel263";
            this.xrLabel263.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel263.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel263.StylePriority.UseBorderDashStyle = false;
            this.xrLabel263.StylePriority.UseBorders = false;
            this.xrLabel263.StylePriority.UsePadding = false;
            // 
            // xrLabel264
            // 
            this.xrLabel264.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel264.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel264.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel264.Multiline = true;
            this.xrLabel264.Name = "xrLabel264";
            this.xrLabel264.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel264.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel264.StylePriority.UseBorderDashStyle = false;
            this.xrLabel264.StylePriority.UseBorders = false;
            this.xrLabel264.StylePriority.UsePadding = false;
            // 
            // xrTableCell49
            // 
            this.xrTableCell49.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell49.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel301,
            this.xrLabel265,
            this.xrLabel266,
            this.xrLabel267,
            this.xrLabel268,
            this.xrLabel269});
            this.xrTableCell49.Multiline = true;
            this.xrTableCell49.Name = "xrTableCell49";
            this.xrTableCell49.StylePriority.UseBorders = false;
            this.xrTableCell49.Weight = 0.20290247599283853D;
            // 
            // xrLabel301
            // 
            this.xrLabel301.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel301.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel301.Multiline = true;
            this.xrLabel301.Name = "xrLabel301";
            this.xrLabel301.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel301.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel301.StylePriority.UseBorders = false;
            this.xrLabel301.StylePriority.UsePadding = false;
            // 
            // xrLabel265
            // 
            this.xrLabel265.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel265.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel265.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel265.Multiline = true;
            this.xrLabel265.Name = "xrLabel265";
            this.xrLabel265.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel265.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel265.StylePriority.UseBorderDashStyle = false;
            this.xrLabel265.StylePriority.UseBorders = false;
            this.xrLabel265.StylePriority.UsePadding = false;
            // 
            // xrLabel266
            // 
            this.xrLabel266.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel266.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel266.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel266.Multiline = true;
            this.xrLabel266.Name = "xrLabel266";
            this.xrLabel266.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel266.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel266.StylePriority.UseBorderDashStyle = false;
            this.xrLabel266.StylePriority.UseBorders = false;
            this.xrLabel266.StylePriority.UsePadding = false;
            // 
            // xrLabel267
            // 
            this.xrLabel267.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel267.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel267.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel267.Multiline = true;
            this.xrLabel267.Name = "xrLabel267";
            this.xrLabel267.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel267.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel267.StylePriority.UseBorderDashStyle = false;
            this.xrLabel267.StylePriority.UseBorders = false;
            this.xrLabel267.StylePriority.UsePadding = false;
            // 
            // xrLabel268
            // 
            this.xrLabel268.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel268.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel268.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel268.Multiline = true;
            this.xrLabel268.Name = "xrLabel268";
            this.xrLabel268.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel268.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel268.StylePriority.UseBorderDashStyle = false;
            this.xrLabel268.StylePriority.UseBorders = false;
            this.xrLabel268.StylePriority.UsePadding = false;
            // 
            // xrLabel269
            // 
            this.xrLabel269.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel269.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel269.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel269.Multiline = true;
            this.xrLabel269.Name = "xrLabel269";
            this.xrLabel269.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel269.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel269.StylePriority.UseBorderDashStyle = false;
            this.xrLabel269.StylePriority.UseBorders = false;
            this.xrLabel269.StylePriority.UsePadding = false;
            // 
            // xrTableCell50
            // 
            this.xrTableCell50.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell50.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel302,
            this.xrLabel270,
            this.xrLabel271,
            this.xrLabel272,
            this.xrLabel273,
            this.xrLabel274});
            this.xrTableCell50.Multiline = true;
            this.xrTableCell50.Name = "xrTableCell50";
            this.xrTableCell50.StylePriority.UseBorders = false;
            this.xrTableCell50.Weight = 0.20290247599283853D;
            // 
            // xrLabel302
            // 
            this.xrLabel302.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel302.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel302.Multiline = true;
            this.xrLabel302.Name = "xrLabel302";
            this.xrLabel302.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel302.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel302.StylePriority.UseBorders = false;
            this.xrLabel302.StylePriority.UsePadding = false;
            // 
            // xrLabel270
            // 
            this.xrLabel270.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel270.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel270.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel270.Multiline = true;
            this.xrLabel270.Name = "xrLabel270";
            this.xrLabel270.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel270.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel270.StylePriority.UseBorderDashStyle = false;
            this.xrLabel270.StylePriority.UseBorders = false;
            this.xrLabel270.StylePriority.UsePadding = false;
            // 
            // xrLabel271
            // 
            this.xrLabel271.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel271.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel271.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel271.Multiline = true;
            this.xrLabel271.Name = "xrLabel271";
            this.xrLabel271.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel271.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel271.StylePriority.UseBorderDashStyle = false;
            this.xrLabel271.StylePriority.UseBorders = false;
            this.xrLabel271.StylePriority.UsePadding = false;
            // 
            // xrLabel272
            // 
            this.xrLabel272.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel272.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel272.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel272.Multiline = true;
            this.xrLabel272.Name = "xrLabel272";
            this.xrLabel272.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel272.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel272.StylePriority.UseBorderDashStyle = false;
            this.xrLabel272.StylePriority.UseBorders = false;
            this.xrLabel272.StylePriority.UsePadding = false;
            // 
            // xrLabel273
            // 
            this.xrLabel273.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel273.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel273.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel273.Multiline = true;
            this.xrLabel273.Name = "xrLabel273";
            this.xrLabel273.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel273.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel273.StylePriority.UseBorderDashStyle = false;
            this.xrLabel273.StylePriority.UseBorders = false;
            this.xrLabel273.StylePriority.UsePadding = false;
            // 
            // xrLabel274
            // 
            this.xrLabel274.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel274.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel274.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel274.Multiline = true;
            this.xrLabel274.Name = "xrLabel274";
            this.xrLabel274.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel274.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel274.StylePriority.UseBorderDashStyle = false;
            this.xrLabel274.StylePriority.UseBorders = false;
            this.xrLabel274.StylePriority.UsePadding = false;
            // 
            // xrTableCell51
            // 
            this.xrTableCell51.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell51.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel303,
            this.xrLabel275,
            this.xrLabel276,
            this.xrLabel277,
            this.xrLabel278,
            this.xrLabel279});
            this.xrTableCell51.Multiline = true;
            this.xrTableCell51.Name = "xrTableCell51";
            this.xrTableCell51.StylePriority.UseBorders = false;
            this.xrTableCell51.Weight = 0.20290247599283853D;
            // 
            // xrLabel303
            // 
            this.xrLabel303.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel303.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel303.Multiline = true;
            this.xrLabel303.Name = "xrLabel303";
            this.xrLabel303.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel303.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel303.StylePriority.UseBorders = false;
            this.xrLabel303.StylePriority.UsePadding = false;
            // 
            // xrLabel275
            // 
            this.xrLabel275.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel275.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel275.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel275.Multiline = true;
            this.xrLabel275.Name = "xrLabel275";
            this.xrLabel275.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel275.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel275.StylePriority.UseBorderDashStyle = false;
            this.xrLabel275.StylePriority.UseBorders = false;
            this.xrLabel275.StylePriority.UsePadding = false;
            // 
            // xrLabel276
            // 
            this.xrLabel276.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel276.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel276.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel276.Multiline = true;
            this.xrLabel276.Name = "xrLabel276";
            this.xrLabel276.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel276.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel276.StylePriority.UseBorderDashStyle = false;
            this.xrLabel276.StylePriority.UseBorders = false;
            this.xrLabel276.StylePriority.UsePadding = false;
            // 
            // xrLabel277
            // 
            this.xrLabel277.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel277.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel277.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel277.Multiline = true;
            this.xrLabel277.Name = "xrLabel277";
            this.xrLabel277.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel277.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel277.StylePriority.UseBorderDashStyle = false;
            this.xrLabel277.StylePriority.UseBorders = false;
            this.xrLabel277.StylePriority.UsePadding = false;
            // 
            // xrLabel278
            // 
            this.xrLabel278.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel278.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel278.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel278.Multiline = true;
            this.xrLabel278.Name = "xrLabel278";
            this.xrLabel278.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel278.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel278.StylePriority.UseBorderDashStyle = false;
            this.xrLabel278.StylePriority.UseBorders = false;
            this.xrLabel278.StylePriority.UsePadding = false;
            // 
            // xrLabel279
            // 
            this.xrLabel279.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel279.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel279.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel279.Multiline = true;
            this.xrLabel279.Name = "xrLabel279";
            this.xrLabel279.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel279.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel279.StylePriority.UseBorderDashStyle = false;
            this.xrLabel279.StylePriority.UseBorders = false;
            this.xrLabel279.StylePriority.UsePadding = false;
            // 
            // xrTableCell52
            // 
            this.xrTableCell52.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell52.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel304,
            this.xrLabel280,
            this.xrLabel281,
            this.xrLabel282,
            this.xrLabel283,
            this.xrLabel284});
            this.xrTableCell52.Multiline = true;
            this.xrTableCell52.Name = "xrTableCell52";
            this.xrTableCell52.StylePriority.UseBorders = false;
            this.xrTableCell52.Weight = 0.20290247599283853D;
            // 
            // xrLabel304
            // 
            this.xrLabel304.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel304.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel304.Multiline = true;
            this.xrLabel304.Name = "xrLabel304";
            this.xrLabel304.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel304.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel304.StylePriority.UseBorders = false;
            this.xrLabel304.StylePriority.UsePadding = false;
            // 
            // xrLabel280
            // 
            this.xrLabel280.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel280.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel280.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel280.Multiline = true;
            this.xrLabel280.Name = "xrLabel280";
            this.xrLabel280.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel280.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel280.StylePriority.UseBorderDashStyle = false;
            this.xrLabel280.StylePriority.UseBorders = false;
            this.xrLabel280.StylePriority.UsePadding = false;
            // 
            // xrLabel281
            // 
            this.xrLabel281.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel281.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel281.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel281.Multiline = true;
            this.xrLabel281.Name = "xrLabel281";
            this.xrLabel281.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel281.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel281.StylePriority.UseBorderDashStyle = false;
            this.xrLabel281.StylePriority.UseBorders = false;
            this.xrLabel281.StylePriority.UsePadding = false;
            // 
            // xrLabel282
            // 
            this.xrLabel282.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel282.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel282.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel282.Multiline = true;
            this.xrLabel282.Name = "xrLabel282";
            this.xrLabel282.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel282.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel282.StylePriority.UseBorderDashStyle = false;
            this.xrLabel282.StylePriority.UseBorders = false;
            this.xrLabel282.StylePriority.UsePadding = false;
            // 
            // xrLabel283
            // 
            this.xrLabel283.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel283.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel283.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel283.Multiline = true;
            this.xrLabel283.Name = "xrLabel283";
            this.xrLabel283.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel283.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel283.StylePriority.UseBorderDashStyle = false;
            this.xrLabel283.StylePriority.UseBorders = false;
            this.xrLabel283.StylePriority.UsePadding = false;
            // 
            // xrLabel284
            // 
            this.xrLabel284.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel284.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel284.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel284.Multiline = true;
            this.xrLabel284.Name = "xrLabel284";
            this.xrLabel284.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel284.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel284.StylePriority.UseBorderDashStyle = false;
            this.xrLabel284.StylePriority.UseBorders = false;
            this.xrLabel284.StylePriority.UsePadding = false;
            // 
            // xrTableCell53
            // 
            this.xrTableCell53.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell53.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel305,
            this.xrLabel285,
            this.xrLabel286,
            this.xrLabel287,
            this.xrLabel288,
            this.xrLabel289});
            this.xrTableCell53.Multiline = true;
            this.xrTableCell53.Name = "xrTableCell53";
            this.xrTableCell53.StylePriority.UseBorders = false;
            this.xrTableCell53.Weight = 0.20290247599283853D;
            // 
            // xrLabel305
            // 
            this.xrLabel305.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel305.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-06F, 74.99985F);
            this.xrLabel305.Multiline = true;
            this.xrLabel305.Name = "xrLabel305";
            this.xrLabel305.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel305.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel305.StylePriority.UseBorders = false;
            this.xrLabel305.StylePriority.UsePadding = false;
            // 
            // xrLabel285
            // 
            this.xrLabel285.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel285.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel285.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel285.Multiline = true;
            this.xrLabel285.Name = "xrLabel285";
            this.xrLabel285.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel285.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel285.StylePriority.UseBorderDashStyle = false;
            this.xrLabel285.StylePriority.UseBorders = false;
            this.xrLabel285.StylePriority.UsePadding = false;
            // 
            // xrLabel286
            // 
            this.xrLabel286.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel286.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel286.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel286.Multiline = true;
            this.xrLabel286.Name = "xrLabel286";
            this.xrLabel286.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel286.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel286.StylePriority.UseBorderDashStyle = false;
            this.xrLabel286.StylePriority.UseBorders = false;
            this.xrLabel286.StylePriority.UsePadding = false;
            // 
            // xrLabel287
            // 
            this.xrLabel287.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel287.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel287.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel287.Multiline = true;
            this.xrLabel287.Name = "xrLabel287";
            this.xrLabel287.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel287.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel287.StylePriority.UseBorderDashStyle = false;
            this.xrLabel287.StylePriority.UseBorders = false;
            this.xrLabel287.StylePriority.UsePadding = false;
            // 
            // xrLabel288
            // 
            this.xrLabel288.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel288.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel288.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel288.Multiline = true;
            this.xrLabel288.Name = "xrLabel288";
            this.xrLabel288.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel288.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel288.StylePriority.UseBorderDashStyle = false;
            this.xrLabel288.StylePriority.UseBorders = false;
            this.xrLabel288.StylePriority.UsePadding = false;
            // 
            // xrLabel289
            // 
            this.xrLabel289.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel289.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel289.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel289.Multiline = true;
            this.xrLabel289.Name = "xrLabel289";
            this.xrLabel289.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel289.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel289.StylePriority.UseBorderDashStyle = false;
            this.xrLabel289.StylePriority.UseBorders = false;
            this.xrLabel289.StylePriority.UsePadding = false;
            // 
            // xrTableCell54
            // 
            this.xrTableCell54.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell54.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel306,
            this.xrLabel290,
            this.xrLabel291,
            this.xrLabel292,
            this.xrLabel293,
            this.xrLabel294});
            this.xrTableCell54.Multiline = true;
            this.xrTableCell54.Name = "xrTableCell54";
            this.xrTableCell54.StylePriority.UseBorders = false;
            this.xrTableCell54.Weight = 0.20290247599283853D;
            // 
            // xrLabel306
            // 
            this.xrLabel306.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel306.LocationFloat = new DevExpress.Utils.PointFloat(0F, 74.99985F);
            this.xrLabel306.Multiline = true;
            this.xrLabel306.Name = "xrLabel306";
            this.xrLabel306.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel306.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel306.StylePriority.UseBorders = false;
            this.xrLabel306.StylePriority.UsePadding = false;
            // 
            // xrLabel290
            // 
            this.xrLabel290.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel290.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel290.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel290.Multiline = true;
            this.xrLabel290.Name = "xrLabel290";
            this.xrLabel290.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel290.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel290.StylePriority.UseBorderDashStyle = false;
            this.xrLabel290.StylePriority.UseBorders = false;
            this.xrLabel290.StylePriority.UsePadding = false;
            // 
            // xrLabel291
            // 
            this.xrLabel291.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel291.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel291.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel291.Multiline = true;
            this.xrLabel291.Name = "xrLabel291";
            this.xrLabel291.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel291.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel291.StylePriority.UseBorderDashStyle = false;
            this.xrLabel291.StylePriority.UseBorders = false;
            this.xrLabel291.StylePriority.UsePadding = false;
            // 
            // xrLabel292
            // 
            this.xrLabel292.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel292.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel292.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel292.Multiline = true;
            this.xrLabel292.Name = "xrLabel292";
            this.xrLabel292.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel292.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel292.StylePriority.UseBorderDashStyle = false;
            this.xrLabel292.StylePriority.UseBorders = false;
            this.xrLabel292.StylePriority.UsePadding = false;
            // 
            // xrLabel293
            // 
            this.xrLabel293.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel293.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel293.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel293.Multiline = true;
            this.xrLabel293.Name = "xrLabel293";
            this.xrLabel293.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel293.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel293.StylePriority.UseBorderDashStyle = false;
            this.xrLabel293.StylePriority.UseBorders = false;
            this.xrLabel293.StylePriority.UsePadding = false;
            // 
            // xrLabel294
            // 
            this.xrLabel294.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel294.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel294.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel294.Multiline = true;
            this.xrLabel294.Name = "xrLabel294";
            this.xrLabel294.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel294.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel294.StylePriority.UseBorderDashStyle = false;
            this.xrLabel294.StylePriority.UseBorders = false;
            this.xrLabel294.StylePriority.UsePadding = false;
            // 
            // xrTable5
            // 
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 163.3553F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
            this.xrTable5.SizeF = new System.Drawing.SizeF(372.019F, 74.11594F);
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell31,
            this.xrTableCell32,
            this.xrTableCell33,
            this.xrTableCell34,
            this.xrTableCell35,
            this.xrTableCell36,
            this.xrTableCell37,
            this.xrTableCell38,
            this.xrTableCell39,
            this.xrTableCell40,
            this.xrTableCell41,
            this.xrTableCell42});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell31.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel175,
            this.xrLabel176,
            this.xrLabel177,
            this.xrLabel178,
            this.xrLabel179});
            this.xrTableCell31.Multiline = true;
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.StylePriority.UseBorders = false;
            this.xrTableCell31.Weight = 0.20290247599283853D;
            // 
            // xrLabel175
            // 
            this.xrLabel175.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel175.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel175.Multiline = true;
            this.xrLabel175.Name = "xrLabel175";
            this.xrLabel175.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel175.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel175.StylePriority.UseBorders = false;
            this.xrLabel175.StylePriority.UsePadding = false;
            // 
            // xrLabel176
            // 
            this.xrLabel176.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel176.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel176.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel176.Multiline = true;
            this.xrLabel176.Name = "xrLabel176";
            this.xrLabel176.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel176.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel176.StylePriority.UseBorderDashStyle = false;
            this.xrLabel176.StylePriority.UseBorders = false;
            this.xrLabel176.StylePriority.UsePadding = false;
            // 
            // xrLabel177
            // 
            this.xrLabel177.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel177.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel177.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel177.Multiline = true;
            this.xrLabel177.Name = "xrLabel177";
            this.xrLabel177.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel177.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel177.StylePriority.UseBorderDashStyle = false;
            this.xrLabel177.StylePriority.UseBorders = false;
            this.xrLabel177.StylePriority.UsePadding = false;
            // 
            // xrLabel178
            // 
            this.xrLabel178.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel178.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel178.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel178.Multiline = true;
            this.xrLabel178.Name = "xrLabel178";
            this.xrLabel178.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel178.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel178.StylePriority.UseBorderDashStyle = false;
            this.xrLabel178.StylePriority.UseBorders = false;
            this.xrLabel178.StylePriority.UsePadding = false;
            // 
            // xrLabel179
            // 
            this.xrLabel179.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel179.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel179.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel179.Multiline = true;
            this.xrLabel179.Name = "xrLabel179";
            this.xrLabel179.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel179.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel179.StylePriority.UseBorderDashStyle = false;
            this.xrLabel179.StylePriority.UseBorders = false;
            this.xrLabel179.StylePriority.UsePadding = false;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell32.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel180,
            this.xrLabel181,
            this.xrLabel182,
            this.xrLabel183,
            this.xrLabel184});
            this.xrTableCell32.Multiline = true;
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.StylePriority.UseBorders = false;
            this.xrTableCell32.Weight = 0.20290247599283853D;
            // 
            // xrLabel180
            // 
            this.xrLabel180.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel180.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel180.Multiline = true;
            this.xrLabel180.Name = "xrLabel180";
            this.xrLabel180.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel180.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel180.StylePriority.UseBorders = false;
            this.xrLabel180.StylePriority.UsePadding = false;
            // 
            // xrLabel181
            // 
            this.xrLabel181.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel181.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel181.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel181.Multiline = true;
            this.xrLabel181.Name = "xrLabel181";
            this.xrLabel181.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel181.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel181.StylePriority.UseBorderDashStyle = false;
            this.xrLabel181.StylePriority.UseBorders = false;
            this.xrLabel181.StylePriority.UsePadding = false;
            // 
            // xrLabel182
            // 
            this.xrLabel182.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel182.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel182.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel182.Multiline = true;
            this.xrLabel182.Name = "xrLabel182";
            this.xrLabel182.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel182.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel182.StylePriority.UseBorderDashStyle = false;
            this.xrLabel182.StylePriority.UseBorders = false;
            this.xrLabel182.StylePriority.UsePadding = false;
            // 
            // xrLabel183
            // 
            this.xrLabel183.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel183.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel183.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel183.Multiline = true;
            this.xrLabel183.Name = "xrLabel183";
            this.xrLabel183.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel183.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel183.StylePriority.UseBorderDashStyle = false;
            this.xrLabel183.StylePriority.UseBorders = false;
            this.xrLabel183.StylePriority.UsePadding = false;
            // 
            // xrLabel184
            // 
            this.xrLabel184.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel184.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel184.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel184.Multiline = true;
            this.xrLabel184.Name = "xrLabel184";
            this.xrLabel184.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel184.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel184.StylePriority.UseBorderDashStyle = false;
            this.xrLabel184.StylePriority.UseBorders = false;
            this.xrLabel184.StylePriority.UsePadding = false;
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell33.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel185,
            this.xrLabel186,
            this.xrLabel187,
            this.xrLabel188,
            this.xrLabel189});
            this.xrTableCell33.Multiline = true;
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.StylePriority.UseBorders = false;
            this.xrTableCell33.Weight = 0.20290247599283853D;
            // 
            // xrLabel185
            // 
            this.xrLabel185.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel185.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel185.Multiline = true;
            this.xrLabel185.Name = "xrLabel185";
            this.xrLabel185.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel185.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel185.StylePriority.UseBorders = false;
            this.xrLabel185.StylePriority.UsePadding = false;
            // 
            // xrLabel186
            // 
            this.xrLabel186.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel186.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel186.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel186.Multiline = true;
            this.xrLabel186.Name = "xrLabel186";
            this.xrLabel186.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel186.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel186.StylePriority.UseBorderDashStyle = false;
            this.xrLabel186.StylePriority.UseBorders = false;
            this.xrLabel186.StylePriority.UsePadding = false;
            // 
            // xrLabel187
            // 
            this.xrLabel187.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel187.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel187.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel187.Multiline = true;
            this.xrLabel187.Name = "xrLabel187";
            this.xrLabel187.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel187.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel187.StylePriority.UseBorderDashStyle = false;
            this.xrLabel187.StylePriority.UseBorders = false;
            this.xrLabel187.StylePriority.UsePadding = false;
            // 
            // xrLabel188
            // 
            this.xrLabel188.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel188.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel188.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel188.Multiline = true;
            this.xrLabel188.Name = "xrLabel188";
            this.xrLabel188.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel188.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel188.StylePriority.UseBorderDashStyle = false;
            this.xrLabel188.StylePriority.UseBorders = false;
            this.xrLabel188.StylePriority.UsePadding = false;
            // 
            // xrLabel189
            // 
            this.xrLabel189.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel189.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel189.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel189.Multiline = true;
            this.xrLabel189.Name = "xrLabel189";
            this.xrLabel189.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel189.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel189.StylePriority.UseBorderDashStyle = false;
            this.xrLabel189.StylePriority.UseBorders = false;
            this.xrLabel189.StylePriority.UsePadding = false;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell34.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel190,
            this.xrLabel191,
            this.xrLabel192,
            this.xrLabel193,
            this.xrLabel194});
            this.xrTableCell34.Multiline = true;
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.StylePriority.UseBorders = false;
            this.xrTableCell34.Weight = 0.20290247599283853D;
            // 
            // xrLabel190
            // 
            this.xrLabel190.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel190.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel190.Multiline = true;
            this.xrLabel190.Name = "xrLabel190";
            this.xrLabel190.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel190.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel190.StylePriority.UseBorders = false;
            this.xrLabel190.StylePriority.UsePadding = false;
            // 
            // xrLabel191
            // 
            this.xrLabel191.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel191.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel191.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel191.Multiline = true;
            this.xrLabel191.Name = "xrLabel191";
            this.xrLabel191.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel191.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel191.StylePriority.UseBorderDashStyle = false;
            this.xrLabel191.StylePriority.UseBorders = false;
            this.xrLabel191.StylePriority.UsePadding = false;
            // 
            // xrLabel192
            // 
            this.xrLabel192.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel192.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel192.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel192.Multiline = true;
            this.xrLabel192.Name = "xrLabel192";
            this.xrLabel192.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel192.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel192.StylePriority.UseBorderDashStyle = false;
            this.xrLabel192.StylePriority.UseBorders = false;
            this.xrLabel192.StylePriority.UsePadding = false;
            // 
            // xrLabel193
            // 
            this.xrLabel193.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel193.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel193.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel193.Multiline = true;
            this.xrLabel193.Name = "xrLabel193";
            this.xrLabel193.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel193.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel193.StylePriority.UseBorderDashStyle = false;
            this.xrLabel193.StylePriority.UseBorders = false;
            this.xrLabel193.StylePriority.UsePadding = false;
            // 
            // xrLabel194
            // 
            this.xrLabel194.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel194.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel194.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel194.Multiline = true;
            this.xrLabel194.Name = "xrLabel194";
            this.xrLabel194.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel194.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel194.StylePriority.UseBorderDashStyle = false;
            this.xrLabel194.StylePriority.UseBorders = false;
            this.xrLabel194.StylePriority.UsePadding = false;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell35.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel195,
            this.xrLabel196,
            this.xrLabel197,
            this.xrLabel198,
            this.xrLabel199});
            this.xrTableCell35.Multiline = true;
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.StylePriority.UseBorders = false;
            this.xrTableCell35.Weight = 0.20290247599283853D;
            // 
            // xrLabel195
            // 
            this.xrLabel195.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel195.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel195.Multiline = true;
            this.xrLabel195.Name = "xrLabel195";
            this.xrLabel195.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel195.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel195.StylePriority.UseBorders = false;
            this.xrLabel195.StylePriority.UsePadding = false;
            // 
            // xrLabel196
            // 
            this.xrLabel196.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel196.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel196.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel196.Multiline = true;
            this.xrLabel196.Name = "xrLabel196";
            this.xrLabel196.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel196.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel196.StylePriority.UseBorderDashStyle = false;
            this.xrLabel196.StylePriority.UseBorders = false;
            this.xrLabel196.StylePriority.UsePadding = false;
            // 
            // xrLabel197
            // 
            this.xrLabel197.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel197.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel197.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel197.Multiline = true;
            this.xrLabel197.Name = "xrLabel197";
            this.xrLabel197.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel197.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel197.StylePriority.UseBorderDashStyle = false;
            this.xrLabel197.StylePriority.UseBorders = false;
            this.xrLabel197.StylePriority.UsePadding = false;
            // 
            // xrLabel198
            // 
            this.xrLabel198.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel198.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel198.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel198.Multiline = true;
            this.xrLabel198.Name = "xrLabel198";
            this.xrLabel198.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel198.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel198.StylePriority.UseBorderDashStyle = false;
            this.xrLabel198.StylePriority.UseBorders = false;
            this.xrLabel198.StylePriority.UsePadding = false;
            // 
            // xrLabel199
            // 
            this.xrLabel199.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel199.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel199.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel199.Multiline = true;
            this.xrLabel199.Name = "xrLabel199";
            this.xrLabel199.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel199.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel199.StylePriority.UseBorderDashStyle = false;
            this.xrLabel199.StylePriority.UseBorders = false;
            this.xrLabel199.StylePriority.UsePadding = false;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell36.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel200,
            this.xrLabel201,
            this.xrLabel202,
            this.xrLabel203,
            this.xrLabel204});
            this.xrTableCell36.Multiline = true;
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.StylePriority.UseBorders = false;
            this.xrTableCell36.Weight = 0.20290247599283853D;
            // 
            // xrLabel200
            // 
            this.xrLabel200.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel200.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel200.Multiline = true;
            this.xrLabel200.Name = "xrLabel200";
            this.xrLabel200.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel200.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel200.StylePriority.UseBorders = false;
            this.xrLabel200.StylePriority.UsePadding = false;
            // 
            // xrLabel201
            // 
            this.xrLabel201.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel201.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel201.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel201.Multiline = true;
            this.xrLabel201.Name = "xrLabel201";
            this.xrLabel201.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel201.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel201.StylePriority.UseBorderDashStyle = false;
            this.xrLabel201.StylePriority.UseBorders = false;
            this.xrLabel201.StylePriority.UsePadding = false;
            // 
            // xrLabel202
            // 
            this.xrLabel202.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel202.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel202.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel202.Multiline = true;
            this.xrLabel202.Name = "xrLabel202";
            this.xrLabel202.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel202.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel202.StylePriority.UseBorderDashStyle = false;
            this.xrLabel202.StylePriority.UseBorders = false;
            this.xrLabel202.StylePriority.UsePadding = false;
            // 
            // xrLabel203
            // 
            this.xrLabel203.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel203.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel203.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel203.Multiline = true;
            this.xrLabel203.Name = "xrLabel203";
            this.xrLabel203.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel203.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel203.StylePriority.UseBorderDashStyle = false;
            this.xrLabel203.StylePriority.UseBorders = false;
            this.xrLabel203.StylePriority.UsePadding = false;
            // 
            // xrLabel204
            // 
            this.xrLabel204.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel204.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel204.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel204.Multiline = true;
            this.xrLabel204.Name = "xrLabel204";
            this.xrLabel204.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel204.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel204.StylePriority.UseBorderDashStyle = false;
            this.xrLabel204.StylePriority.UseBorders = false;
            this.xrLabel204.StylePriority.UsePadding = false;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell37.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel205,
            this.xrLabel206,
            this.xrLabel207,
            this.xrLabel208,
            this.xrLabel209});
            this.xrTableCell37.Multiline = true;
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.StylePriority.UseBorders = false;
            this.xrTableCell37.Weight = 0.20290247599283853D;
            // 
            // xrLabel205
            // 
            this.xrLabel205.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel205.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel205.Multiline = true;
            this.xrLabel205.Name = "xrLabel205";
            this.xrLabel205.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel205.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel205.StylePriority.UseBorders = false;
            this.xrLabel205.StylePriority.UsePadding = false;
            // 
            // xrLabel206
            // 
            this.xrLabel206.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel206.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel206.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel206.Multiline = true;
            this.xrLabel206.Name = "xrLabel206";
            this.xrLabel206.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel206.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel206.StylePriority.UseBorderDashStyle = false;
            this.xrLabel206.StylePriority.UseBorders = false;
            this.xrLabel206.StylePriority.UsePadding = false;
            // 
            // xrLabel207
            // 
            this.xrLabel207.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel207.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel207.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel207.Multiline = true;
            this.xrLabel207.Name = "xrLabel207";
            this.xrLabel207.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel207.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel207.StylePriority.UseBorderDashStyle = false;
            this.xrLabel207.StylePriority.UseBorders = false;
            this.xrLabel207.StylePriority.UsePadding = false;
            // 
            // xrLabel208
            // 
            this.xrLabel208.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel208.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel208.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel208.Multiline = true;
            this.xrLabel208.Name = "xrLabel208";
            this.xrLabel208.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel208.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel208.StylePriority.UseBorderDashStyle = false;
            this.xrLabel208.StylePriority.UseBorders = false;
            this.xrLabel208.StylePriority.UsePadding = false;
            // 
            // xrLabel209
            // 
            this.xrLabel209.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel209.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel209.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel209.Multiline = true;
            this.xrLabel209.Name = "xrLabel209";
            this.xrLabel209.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel209.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel209.StylePriority.UseBorderDashStyle = false;
            this.xrLabel209.StylePriority.UseBorders = false;
            this.xrLabel209.StylePriority.UsePadding = false;
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell38.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel210,
            this.xrLabel211,
            this.xrLabel212,
            this.xrLabel213,
            this.xrLabel214});
            this.xrTableCell38.Multiline = true;
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.StylePriority.UseBorders = false;
            this.xrTableCell38.Weight = 0.20290247599283853D;
            // 
            // xrLabel210
            // 
            this.xrLabel210.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel210.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel210.Multiline = true;
            this.xrLabel210.Name = "xrLabel210";
            this.xrLabel210.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel210.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel210.StylePriority.UseBorders = false;
            this.xrLabel210.StylePriority.UsePadding = false;
            // 
            // xrLabel211
            // 
            this.xrLabel211.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel211.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel211.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel211.Multiline = true;
            this.xrLabel211.Name = "xrLabel211";
            this.xrLabel211.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel211.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel211.StylePriority.UseBorderDashStyle = false;
            this.xrLabel211.StylePriority.UseBorders = false;
            this.xrLabel211.StylePriority.UsePadding = false;
            // 
            // xrLabel212
            // 
            this.xrLabel212.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel212.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel212.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel212.Multiline = true;
            this.xrLabel212.Name = "xrLabel212";
            this.xrLabel212.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel212.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel212.StylePriority.UseBorderDashStyle = false;
            this.xrLabel212.StylePriority.UseBorders = false;
            this.xrLabel212.StylePriority.UsePadding = false;
            // 
            // xrLabel213
            // 
            this.xrLabel213.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel213.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel213.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel213.Multiline = true;
            this.xrLabel213.Name = "xrLabel213";
            this.xrLabel213.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel213.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel213.StylePriority.UseBorderDashStyle = false;
            this.xrLabel213.StylePriority.UseBorders = false;
            this.xrLabel213.StylePriority.UsePadding = false;
            // 
            // xrLabel214
            // 
            this.xrLabel214.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel214.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel214.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel214.Multiline = true;
            this.xrLabel214.Name = "xrLabel214";
            this.xrLabel214.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel214.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel214.StylePriority.UseBorderDashStyle = false;
            this.xrLabel214.StylePriority.UseBorders = false;
            this.xrLabel214.StylePriority.UsePadding = false;
            // 
            // xrTableCell39
            // 
            this.xrTableCell39.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell39.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel215,
            this.xrLabel216,
            this.xrLabel217,
            this.xrLabel218,
            this.xrLabel219});
            this.xrTableCell39.Multiline = true;
            this.xrTableCell39.Name = "xrTableCell39";
            this.xrTableCell39.StylePriority.UseBorders = false;
            this.xrTableCell39.Weight = 0.20290247599283853D;
            // 
            // xrLabel215
            // 
            this.xrLabel215.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel215.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel215.Multiline = true;
            this.xrLabel215.Name = "xrLabel215";
            this.xrLabel215.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel215.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel215.StylePriority.UseBorders = false;
            this.xrLabel215.StylePriority.UsePadding = false;
            // 
            // xrLabel216
            // 
            this.xrLabel216.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel216.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel216.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel216.Multiline = true;
            this.xrLabel216.Name = "xrLabel216";
            this.xrLabel216.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel216.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel216.StylePriority.UseBorderDashStyle = false;
            this.xrLabel216.StylePriority.UseBorders = false;
            this.xrLabel216.StylePriority.UsePadding = false;
            // 
            // xrLabel217
            // 
            this.xrLabel217.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel217.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel217.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel217.Multiline = true;
            this.xrLabel217.Name = "xrLabel217";
            this.xrLabel217.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel217.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel217.StylePriority.UseBorderDashStyle = false;
            this.xrLabel217.StylePriority.UseBorders = false;
            this.xrLabel217.StylePriority.UsePadding = false;
            // 
            // xrLabel218
            // 
            this.xrLabel218.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel218.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel218.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel218.Multiline = true;
            this.xrLabel218.Name = "xrLabel218";
            this.xrLabel218.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel218.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel218.StylePriority.UseBorderDashStyle = false;
            this.xrLabel218.StylePriority.UseBorders = false;
            this.xrLabel218.StylePriority.UsePadding = false;
            // 
            // xrLabel219
            // 
            this.xrLabel219.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel219.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel219.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel219.Multiline = true;
            this.xrLabel219.Name = "xrLabel219";
            this.xrLabel219.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel219.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel219.StylePriority.UseBorderDashStyle = false;
            this.xrLabel219.StylePriority.UseBorders = false;
            this.xrLabel219.StylePriority.UsePadding = false;
            // 
            // xrTableCell40
            // 
            this.xrTableCell40.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell40.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel220,
            this.xrLabel221,
            this.xrLabel222,
            this.xrLabel223,
            this.xrLabel224});
            this.xrTableCell40.Multiline = true;
            this.xrTableCell40.Name = "xrTableCell40";
            this.xrTableCell40.StylePriority.UseBorders = false;
            this.xrTableCell40.Weight = 0.20290247599283853D;
            // 
            // xrLabel220
            // 
            this.xrLabel220.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel220.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel220.Multiline = true;
            this.xrLabel220.Name = "xrLabel220";
            this.xrLabel220.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel220.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel220.StylePriority.UseBorders = false;
            this.xrLabel220.StylePriority.UsePadding = false;
            // 
            // xrLabel221
            // 
            this.xrLabel221.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel221.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel221.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel221.Multiline = true;
            this.xrLabel221.Name = "xrLabel221";
            this.xrLabel221.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel221.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel221.StylePriority.UseBorderDashStyle = false;
            this.xrLabel221.StylePriority.UseBorders = false;
            this.xrLabel221.StylePriority.UsePadding = false;
            // 
            // xrLabel222
            // 
            this.xrLabel222.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel222.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel222.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel222.Multiline = true;
            this.xrLabel222.Name = "xrLabel222";
            this.xrLabel222.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel222.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel222.StylePriority.UseBorderDashStyle = false;
            this.xrLabel222.StylePriority.UseBorders = false;
            this.xrLabel222.StylePriority.UsePadding = false;
            // 
            // xrLabel223
            // 
            this.xrLabel223.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel223.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel223.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel223.Multiline = true;
            this.xrLabel223.Name = "xrLabel223";
            this.xrLabel223.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel223.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel223.StylePriority.UseBorderDashStyle = false;
            this.xrLabel223.StylePriority.UseBorders = false;
            this.xrLabel223.StylePriority.UsePadding = false;
            // 
            // xrLabel224
            // 
            this.xrLabel224.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel224.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel224.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel224.Multiline = true;
            this.xrLabel224.Name = "xrLabel224";
            this.xrLabel224.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel224.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel224.StylePriority.UseBorderDashStyle = false;
            this.xrLabel224.StylePriority.UseBorders = false;
            this.xrLabel224.StylePriority.UsePadding = false;
            // 
            // xrTableCell41
            // 
            this.xrTableCell41.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell41.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel225,
            this.xrLabel226,
            this.xrLabel227,
            this.xrLabel228,
            this.xrLabel229});
            this.xrTableCell41.Multiline = true;
            this.xrTableCell41.Name = "xrTableCell41";
            this.xrTableCell41.StylePriority.UseBorders = false;
            this.xrTableCell41.Weight = 0.20290247599283853D;
            // 
            // xrLabel225
            // 
            this.xrLabel225.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel225.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel225.Multiline = true;
            this.xrLabel225.Name = "xrLabel225";
            this.xrLabel225.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel225.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel225.StylePriority.UseBorders = false;
            this.xrLabel225.StylePriority.UsePadding = false;
            // 
            // xrLabel226
            // 
            this.xrLabel226.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel226.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel226.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel226.Multiline = true;
            this.xrLabel226.Name = "xrLabel226";
            this.xrLabel226.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel226.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel226.StylePriority.UseBorderDashStyle = false;
            this.xrLabel226.StylePriority.UseBorders = false;
            this.xrLabel226.StylePriority.UsePadding = false;
            // 
            // xrLabel227
            // 
            this.xrLabel227.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel227.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel227.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel227.Multiline = true;
            this.xrLabel227.Name = "xrLabel227";
            this.xrLabel227.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel227.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel227.StylePriority.UseBorderDashStyle = false;
            this.xrLabel227.StylePriority.UseBorders = false;
            this.xrLabel227.StylePriority.UsePadding = false;
            // 
            // xrLabel228
            // 
            this.xrLabel228.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel228.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel228.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel228.Multiline = true;
            this.xrLabel228.Name = "xrLabel228";
            this.xrLabel228.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel228.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel228.StylePriority.UseBorderDashStyle = false;
            this.xrLabel228.StylePriority.UseBorders = false;
            this.xrLabel228.StylePriority.UsePadding = false;
            // 
            // xrLabel229
            // 
            this.xrLabel229.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel229.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel229.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel229.Multiline = true;
            this.xrLabel229.Name = "xrLabel229";
            this.xrLabel229.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel229.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel229.StylePriority.UseBorderDashStyle = false;
            this.xrLabel229.StylePriority.UseBorders = false;
            this.xrLabel229.StylePriority.UsePadding = false;
            // 
            // xrTableCell42
            // 
            this.xrTableCell42.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell42.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel230,
            this.xrLabel231,
            this.xrLabel232,
            this.xrLabel233,
            this.xrLabel234});
            this.xrTableCell42.Multiline = true;
            this.xrTableCell42.Name = "xrTableCell42";
            this.xrTableCell42.StylePriority.UseBorders = false;
            this.xrTableCell42.Weight = 0.20290247599283853D;
            // 
            // xrLabel230
            // 
            this.xrLabel230.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel230.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel230.Multiline = true;
            this.xrLabel230.Name = "xrLabel230";
            this.xrLabel230.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel230.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel230.StylePriority.UseBorders = false;
            this.xrLabel230.StylePriority.UsePadding = false;
            // 
            // xrLabel231
            // 
            this.xrLabel231.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel231.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel231.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel231.Multiline = true;
            this.xrLabel231.Name = "xrLabel231";
            this.xrLabel231.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel231.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel231.StylePriority.UseBorderDashStyle = false;
            this.xrLabel231.StylePriority.UseBorders = false;
            this.xrLabel231.StylePriority.UsePadding = false;
            // 
            // xrLabel232
            // 
            this.xrLabel232.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel232.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel232.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel232.Multiline = true;
            this.xrLabel232.Name = "xrLabel232";
            this.xrLabel232.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel232.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel232.StylePriority.UseBorderDashStyle = false;
            this.xrLabel232.StylePriority.UseBorders = false;
            this.xrLabel232.StylePriority.UsePadding = false;
            // 
            // xrLabel233
            // 
            this.xrLabel233.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel233.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel233.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel233.Multiline = true;
            this.xrLabel233.Name = "xrLabel233";
            this.xrLabel233.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel233.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel233.StylePriority.UseBorderDashStyle = false;
            this.xrLabel233.StylePriority.UseBorders = false;
            this.xrLabel233.StylePriority.UsePadding = false;
            // 
            // xrLabel234
            // 
            this.xrLabel234.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel234.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel234.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel234.Multiline = true;
            this.xrLabel234.Name = "xrLabel234";
            this.xrLabel234.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel234.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel234.StylePriority.UseBorderDashStyle = false;
            this.xrLabel234.StylePriority.UseBorders = false;
            this.xrLabel234.StylePriority.UsePadding = false;
            // 
            // xrTable4
            // 
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(0.0001525879F, 89.23941F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
            this.xrTable4.SizeF = new System.Drawing.SizeF(372.019F, 74.11594F);
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell24,
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell27,
            this.xrTableCell28,
            this.xrTableCell29,
            this.xrTableCell30});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell19.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel55,
            this.xrLabel56,
            this.xrLabel57,
            this.xrLabel58,
            this.xrLabel59});
            this.xrTableCell19.Multiline = true;
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.StylePriority.UseBorders = false;
            this.xrTableCell19.Weight = 0.20290247599283853D;
            // 
            // xrLabel55
            // 
            this.xrLabel55.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel55.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel55.Multiline = true;
            this.xrLabel55.Name = "xrLabel55";
            this.xrLabel55.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel55.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel55.StylePriority.UseBorders = false;
            this.xrLabel55.StylePriority.UsePadding = false;
            // 
            // xrLabel56
            // 
            this.xrLabel56.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel56.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel56.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel56.Multiline = true;
            this.xrLabel56.Name = "xrLabel56";
            this.xrLabel56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel56.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel56.StylePriority.UseBorderDashStyle = false;
            this.xrLabel56.StylePriority.UseBorders = false;
            this.xrLabel56.StylePriority.UsePadding = false;
            // 
            // xrLabel57
            // 
            this.xrLabel57.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel57.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel57.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel57.Multiline = true;
            this.xrLabel57.Name = "xrLabel57";
            this.xrLabel57.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel57.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel57.StylePriority.UseBorderDashStyle = false;
            this.xrLabel57.StylePriority.UseBorders = false;
            this.xrLabel57.StylePriority.UsePadding = false;
            // 
            // xrLabel58
            // 
            this.xrLabel58.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel58.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel58.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel58.Multiline = true;
            this.xrLabel58.Name = "xrLabel58";
            this.xrLabel58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel58.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel58.StylePriority.UseBorderDashStyle = false;
            this.xrLabel58.StylePriority.UseBorders = false;
            this.xrLabel58.StylePriority.UsePadding = false;
            // 
            // xrLabel59
            // 
            this.xrLabel59.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel59.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel59.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel59.Multiline = true;
            this.xrLabel59.Name = "xrLabel59";
            this.xrLabel59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel59.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel59.StylePriority.UseBorderDashStyle = false;
            this.xrLabel59.StylePriority.UseBorders = false;
            this.xrLabel59.StylePriority.UsePadding = false;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell20.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel60,
            this.xrLabel61,
            this.xrLabel62,
            this.xrLabel63,
            this.xrLabel64});
            this.xrTableCell20.Multiline = true;
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.StylePriority.UseBorders = false;
            this.xrTableCell20.Weight = 0.20290247599283853D;
            // 
            // xrLabel60
            // 
            this.xrLabel60.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel60.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel60.Multiline = true;
            this.xrLabel60.Name = "xrLabel60";
            this.xrLabel60.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel60.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel60.StylePriority.UseBorders = false;
            this.xrLabel60.StylePriority.UsePadding = false;
            // 
            // xrLabel61
            // 
            this.xrLabel61.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel61.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel61.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel61.Multiline = true;
            this.xrLabel61.Name = "xrLabel61";
            this.xrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel61.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel61.StylePriority.UseBorderDashStyle = false;
            this.xrLabel61.StylePriority.UseBorders = false;
            this.xrLabel61.StylePriority.UsePadding = false;
            // 
            // xrLabel62
            // 
            this.xrLabel62.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel62.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel62.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel62.Multiline = true;
            this.xrLabel62.Name = "xrLabel62";
            this.xrLabel62.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel62.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel62.StylePriority.UseBorderDashStyle = false;
            this.xrLabel62.StylePriority.UseBorders = false;
            this.xrLabel62.StylePriority.UsePadding = false;
            // 
            // xrLabel63
            // 
            this.xrLabel63.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel63.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel63.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel63.Multiline = true;
            this.xrLabel63.Name = "xrLabel63";
            this.xrLabel63.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel63.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel63.StylePriority.UseBorderDashStyle = false;
            this.xrLabel63.StylePriority.UseBorders = false;
            this.xrLabel63.StylePriority.UsePadding = false;
            // 
            // xrLabel64
            // 
            this.xrLabel64.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel64.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel64.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel64.Multiline = true;
            this.xrLabel64.Name = "xrLabel64";
            this.xrLabel64.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel64.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel64.StylePriority.UseBorderDashStyle = false;
            this.xrLabel64.StylePriority.UseBorders = false;
            this.xrLabel64.StylePriority.UsePadding = false;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell21.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel65,
            this.xrLabel66,
            this.xrLabel127,
            this.xrLabel128,
            this.xrLabel129});
            this.xrTableCell21.Multiline = true;
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.StylePriority.UseBorders = false;
            this.xrTableCell21.Weight = 0.20290247599283853D;
            // 
            // xrLabel65
            // 
            this.xrLabel65.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel65.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel65.Multiline = true;
            this.xrLabel65.Name = "xrLabel65";
            this.xrLabel65.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel65.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel65.StylePriority.UseBorders = false;
            this.xrLabel65.StylePriority.UsePadding = false;
            // 
            // xrLabel66
            // 
            this.xrLabel66.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel66.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel66.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel66.Multiline = true;
            this.xrLabel66.Name = "xrLabel66";
            this.xrLabel66.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel66.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel66.StylePriority.UseBorderDashStyle = false;
            this.xrLabel66.StylePriority.UseBorders = false;
            this.xrLabel66.StylePriority.UsePadding = false;
            // 
            // xrLabel127
            // 
            this.xrLabel127.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel127.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel127.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel127.Multiline = true;
            this.xrLabel127.Name = "xrLabel127";
            this.xrLabel127.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel127.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel127.StylePriority.UseBorderDashStyle = false;
            this.xrLabel127.StylePriority.UseBorders = false;
            this.xrLabel127.StylePriority.UsePadding = false;
            // 
            // xrLabel128
            // 
            this.xrLabel128.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel128.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel128.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel128.Multiline = true;
            this.xrLabel128.Name = "xrLabel128";
            this.xrLabel128.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel128.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel128.StylePriority.UseBorderDashStyle = false;
            this.xrLabel128.StylePriority.UseBorders = false;
            this.xrLabel128.StylePriority.UsePadding = false;
            // 
            // xrLabel129
            // 
            this.xrLabel129.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel129.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel129.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel129.Multiline = true;
            this.xrLabel129.Name = "xrLabel129";
            this.xrLabel129.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel129.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel129.StylePriority.UseBorderDashStyle = false;
            this.xrLabel129.StylePriority.UseBorders = false;
            this.xrLabel129.StylePriority.UsePadding = false;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell22.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel130,
            this.xrLabel131,
            this.xrLabel132,
            this.xrLabel133,
            this.xrLabel134});
            this.xrTableCell22.Multiline = true;
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.StylePriority.UseBorders = false;
            this.xrTableCell22.Weight = 0.20290247599283853D;
            // 
            // xrLabel130
            // 
            this.xrLabel130.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel130.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel130.Multiline = true;
            this.xrLabel130.Name = "xrLabel130";
            this.xrLabel130.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel130.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel130.StylePriority.UseBorders = false;
            this.xrLabel130.StylePriority.UsePadding = false;
            // 
            // xrLabel131
            // 
            this.xrLabel131.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel131.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel131.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel131.Multiline = true;
            this.xrLabel131.Name = "xrLabel131";
            this.xrLabel131.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel131.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel131.StylePriority.UseBorderDashStyle = false;
            this.xrLabel131.StylePriority.UseBorders = false;
            this.xrLabel131.StylePriority.UsePadding = false;
            // 
            // xrLabel132
            // 
            this.xrLabel132.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel132.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel132.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel132.Multiline = true;
            this.xrLabel132.Name = "xrLabel132";
            this.xrLabel132.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel132.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel132.StylePriority.UseBorderDashStyle = false;
            this.xrLabel132.StylePriority.UseBorders = false;
            this.xrLabel132.StylePriority.UsePadding = false;
            // 
            // xrLabel133
            // 
            this.xrLabel133.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel133.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel133.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel133.Multiline = true;
            this.xrLabel133.Name = "xrLabel133";
            this.xrLabel133.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel133.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel133.StylePriority.UseBorderDashStyle = false;
            this.xrLabel133.StylePriority.UseBorders = false;
            this.xrLabel133.StylePriority.UsePadding = false;
            // 
            // xrLabel134
            // 
            this.xrLabel134.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel134.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel134.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel134.Multiline = true;
            this.xrLabel134.Name = "xrLabel134";
            this.xrLabel134.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel134.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel134.StylePriority.UseBorderDashStyle = false;
            this.xrLabel134.StylePriority.UseBorders = false;
            this.xrLabel134.StylePriority.UsePadding = false;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell23.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel135,
            this.xrLabel136,
            this.xrLabel137,
            this.xrLabel138,
            this.xrLabel139});
            this.xrTableCell23.Multiline = true;
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.StylePriority.UseBorders = false;
            this.xrTableCell23.Weight = 0.20290247599283853D;
            // 
            // xrLabel135
            // 
            this.xrLabel135.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel135.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel135.Multiline = true;
            this.xrLabel135.Name = "xrLabel135";
            this.xrLabel135.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel135.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel135.StylePriority.UseBorders = false;
            this.xrLabel135.StylePriority.UsePadding = false;
            // 
            // xrLabel136
            // 
            this.xrLabel136.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel136.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel136.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel136.Multiline = true;
            this.xrLabel136.Name = "xrLabel136";
            this.xrLabel136.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel136.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel136.StylePriority.UseBorderDashStyle = false;
            this.xrLabel136.StylePriority.UseBorders = false;
            this.xrLabel136.StylePriority.UsePadding = false;
            // 
            // xrLabel137
            // 
            this.xrLabel137.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel137.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel137.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel137.Multiline = true;
            this.xrLabel137.Name = "xrLabel137";
            this.xrLabel137.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel137.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel137.StylePriority.UseBorderDashStyle = false;
            this.xrLabel137.StylePriority.UseBorders = false;
            this.xrLabel137.StylePriority.UsePadding = false;
            // 
            // xrLabel138
            // 
            this.xrLabel138.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel138.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel138.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel138.Multiline = true;
            this.xrLabel138.Name = "xrLabel138";
            this.xrLabel138.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel138.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel138.StylePriority.UseBorderDashStyle = false;
            this.xrLabel138.StylePriority.UseBorders = false;
            this.xrLabel138.StylePriority.UsePadding = false;
            // 
            // xrLabel139
            // 
            this.xrLabel139.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel139.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel139.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel139.Multiline = true;
            this.xrLabel139.Name = "xrLabel139";
            this.xrLabel139.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel139.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel139.StylePriority.UseBorderDashStyle = false;
            this.xrLabel139.StylePriority.UseBorders = false;
            this.xrLabel139.StylePriority.UsePadding = false;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell24.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel140,
            this.xrLabel141,
            this.xrLabel142,
            this.xrLabel143,
            this.xrLabel144});
            this.xrTableCell24.Multiline = true;
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.StylePriority.UseBorders = false;
            this.xrTableCell24.Weight = 0.20290247599283853D;
            // 
            // xrLabel140
            // 
            this.xrLabel140.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel140.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel140.Multiline = true;
            this.xrLabel140.Name = "xrLabel140";
            this.xrLabel140.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel140.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel140.StylePriority.UseBorders = false;
            this.xrLabel140.StylePriority.UsePadding = false;
            // 
            // xrLabel141
            // 
            this.xrLabel141.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel141.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel141.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel141.Multiline = true;
            this.xrLabel141.Name = "xrLabel141";
            this.xrLabel141.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel141.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel141.StylePriority.UseBorderDashStyle = false;
            this.xrLabel141.StylePriority.UseBorders = false;
            this.xrLabel141.StylePriority.UsePadding = false;
            // 
            // xrLabel142
            // 
            this.xrLabel142.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel142.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel142.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel142.Multiline = true;
            this.xrLabel142.Name = "xrLabel142";
            this.xrLabel142.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel142.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel142.StylePriority.UseBorderDashStyle = false;
            this.xrLabel142.StylePriority.UseBorders = false;
            this.xrLabel142.StylePriority.UsePadding = false;
            // 
            // xrLabel143
            // 
            this.xrLabel143.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel143.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel143.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel143.Multiline = true;
            this.xrLabel143.Name = "xrLabel143";
            this.xrLabel143.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel143.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel143.StylePriority.UseBorderDashStyle = false;
            this.xrLabel143.StylePriority.UseBorders = false;
            this.xrLabel143.StylePriority.UsePadding = false;
            // 
            // xrLabel144
            // 
            this.xrLabel144.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel144.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel144.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel144.Multiline = true;
            this.xrLabel144.Name = "xrLabel144";
            this.xrLabel144.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel144.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel144.StylePriority.UseBorderDashStyle = false;
            this.xrLabel144.StylePriority.UseBorders = false;
            this.xrLabel144.StylePriority.UsePadding = false;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell25.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel145,
            this.xrLabel146,
            this.xrLabel147,
            this.xrLabel148,
            this.xrLabel149});
            this.xrTableCell25.Multiline = true;
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.StylePriority.UseBorders = false;
            this.xrTableCell25.Weight = 0.20290247599283853D;
            // 
            // xrLabel145
            // 
            this.xrLabel145.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel145.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel145.Multiline = true;
            this.xrLabel145.Name = "xrLabel145";
            this.xrLabel145.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel145.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel145.StylePriority.UseBorders = false;
            this.xrLabel145.StylePriority.UsePadding = false;
            // 
            // xrLabel146
            // 
            this.xrLabel146.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel146.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel146.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel146.Multiline = true;
            this.xrLabel146.Name = "xrLabel146";
            this.xrLabel146.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel146.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel146.StylePriority.UseBorderDashStyle = false;
            this.xrLabel146.StylePriority.UseBorders = false;
            this.xrLabel146.StylePriority.UsePadding = false;
            // 
            // xrLabel147
            // 
            this.xrLabel147.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel147.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel147.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel147.Multiline = true;
            this.xrLabel147.Name = "xrLabel147";
            this.xrLabel147.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel147.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel147.StylePriority.UseBorderDashStyle = false;
            this.xrLabel147.StylePriority.UseBorders = false;
            this.xrLabel147.StylePriority.UsePadding = false;
            // 
            // xrLabel148
            // 
            this.xrLabel148.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel148.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel148.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel148.Multiline = true;
            this.xrLabel148.Name = "xrLabel148";
            this.xrLabel148.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel148.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel148.StylePriority.UseBorderDashStyle = false;
            this.xrLabel148.StylePriority.UseBorders = false;
            this.xrLabel148.StylePriority.UsePadding = false;
            // 
            // xrLabel149
            // 
            this.xrLabel149.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel149.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel149.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel149.Multiline = true;
            this.xrLabel149.Name = "xrLabel149";
            this.xrLabel149.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel149.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel149.StylePriority.UseBorderDashStyle = false;
            this.xrLabel149.StylePriority.UseBorders = false;
            this.xrLabel149.StylePriority.UsePadding = false;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell26.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel150,
            this.xrLabel151,
            this.xrLabel152,
            this.xrLabel153,
            this.xrLabel154});
            this.xrTableCell26.Multiline = true;
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.StylePriority.UseBorders = false;
            this.xrTableCell26.Weight = 0.20290247599283853D;
            // 
            // xrLabel150
            // 
            this.xrLabel150.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel150.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel150.Multiline = true;
            this.xrLabel150.Name = "xrLabel150";
            this.xrLabel150.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel150.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel150.StylePriority.UseBorders = false;
            this.xrLabel150.StylePriority.UsePadding = false;
            // 
            // xrLabel151
            // 
            this.xrLabel151.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel151.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel151.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel151.Multiline = true;
            this.xrLabel151.Name = "xrLabel151";
            this.xrLabel151.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel151.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel151.StylePriority.UseBorderDashStyle = false;
            this.xrLabel151.StylePriority.UseBorders = false;
            this.xrLabel151.StylePriority.UsePadding = false;
            // 
            // xrLabel152
            // 
            this.xrLabel152.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel152.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel152.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel152.Multiline = true;
            this.xrLabel152.Name = "xrLabel152";
            this.xrLabel152.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel152.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel152.StylePriority.UseBorderDashStyle = false;
            this.xrLabel152.StylePriority.UseBorders = false;
            this.xrLabel152.StylePriority.UsePadding = false;
            // 
            // xrLabel153
            // 
            this.xrLabel153.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel153.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel153.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel153.Multiline = true;
            this.xrLabel153.Name = "xrLabel153";
            this.xrLabel153.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel153.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel153.StylePriority.UseBorderDashStyle = false;
            this.xrLabel153.StylePriority.UseBorders = false;
            this.xrLabel153.StylePriority.UsePadding = false;
            // 
            // xrLabel154
            // 
            this.xrLabel154.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel154.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel154.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel154.Multiline = true;
            this.xrLabel154.Name = "xrLabel154";
            this.xrLabel154.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel154.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel154.StylePriority.UseBorderDashStyle = false;
            this.xrLabel154.StylePriority.UseBorders = false;
            this.xrLabel154.StylePriority.UsePadding = false;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell27.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel155,
            this.xrLabel156,
            this.xrLabel157,
            this.xrLabel158,
            this.xrLabel159});
            this.xrTableCell27.Multiline = true;
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.StylePriority.UseBorders = false;
            this.xrTableCell27.Weight = 0.20290247599283853D;
            // 
            // xrLabel155
            // 
            this.xrLabel155.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel155.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel155.Multiline = true;
            this.xrLabel155.Name = "xrLabel155";
            this.xrLabel155.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel155.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel155.StylePriority.UseBorders = false;
            this.xrLabel155.StylePriority.UsePadding = false;
            // 
            // xrLabel156
            // 
            this.xrLabel156.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel156.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel156.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel156.Multiline = true;
            this.xrLabel156.Name = "xrLabel156";
            this.xrLabel156.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel156.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel156.StylePriority.UseBorderDashStyle = false;
            this.xrLabel156.StylePriority.UseBorders = false;
            this.xrLabel156.StylePriority.UsePadding = false;
            // 
            // xrLabel157
            // 
            this.xrLabel157.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel157.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel157.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel157.Multiline = true;
            this.xrLabel157.Name = "xrLabel157";
            this.xrLabel157.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel157.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel157.StylePriority.UseBorderDashStyle = false;
            this.xrLabel157.StylePriority.UseBorders = false;
            this.xrLabel157.StylePriority.UsePadding = false;
            // 
            // xrLabel158
            // 
            this.xrLabel158.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel158.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel158.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel158.Multiline = true;
            this.xrLabel158.Name = "xrLabel158";
            this.xrLabel158.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel158.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel158.StylePriority.UseBorderDashStyle = false;
            this.xrLabel158.StylePriority.UseBorders = false;
            this.xrLabel158.StylePriority.UsePadding = false;
            // 
            // xrLabel159
            // 
            this.xrLabel159.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel159.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel159.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel159.Multiline = true;
            this.xrLabel159.Name = "xrLabel159";
            this.xrLabel159.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel159.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel159.StylePriority.UseBorderDashStyle = false;
            this.xrLabel159.StylePriority.UseBorders = false;
            this.xrLabel159.StylePriority.UsePadding = false;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell28.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel160,
            this.xrLabel161,
            this.xrLabel162,
            this.xrLabel163,
            this.xrLabel164});
            this.xrTableCell28.Multiline = true;
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.StylePriority.UseBorders = false;
            this.xrTableCell28.Weight = 0.20290247599283853D;
            // 
            // xrLabel160
            // 
            this.xrLabel160.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel160.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel160.Multiline = true;
            this.xrLabel160.Name = "xrLabel160";
            this.xrLabel160.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel160.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel160.StylePriority.UseBorders = false;
            this.xrLabel160.StylePriority.UsePadding = false;
            // 
            // xrLabel161
            // 
            this.xrLabel161.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel161.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel161.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel161.Multiline = true;
            this.xrLabel161.Name = "xrLabel161";
            this.xrLabel161.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel161.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel161.StylePriority.UseBorderDashStyle = false;
            this.xrLabel161.StylePriority.UseBorders = false;
            this.xrLabel161.StylePriority.UsePadding = false;
            // 
            // xrLabel162
            // 
            this.xrLabel162.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel162.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel162.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel162.Multiline = true;
            this.xrLabel162.Name = "xrLabel162";
            this.xrLabel162.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel162.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel162.StylePriority.UseBorderDashStyle = false;
            this.xrLabel162.StylePriority.UseBorders = false;
            this.xrLabel162.StylePriority.UsePadding = false;
            // 
            // xrLabel163
            // 
            this.xrLabel163.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel163.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel163.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel163.Multiline = true;
            this.xrLabel163.Name = "xrLabel163";
            this.xrLabel163.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel163.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel163.StylePriority.UseBorderDashStyle = false;
            this.xrLabel163.StylePriority.UseBorders = false;
            this.xrLabel163.StylePriority.UsePadding = false;
            // 
            // xrLabel164
            // 
            this.xrLabel164.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel164.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel164.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel164.Multiline = true;
            this.xrLabel164.Name = "xrLabel164";
            this.xrLabel164.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel164.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel164.StylePriority.UseBorderDashStyle = false;
            this.xrLabel164.StylePriority.UseBorders = false;
            this.xrLabel164.StylePriority.UsePadding = false;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell29.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel165,
            this.xrLabel166,
            this.xrLabel167,
            this.xrLabel168,
            this.xrLabel169});
            this.xrTableCell29.Multiline = true;
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.StylePriority.UseBorders = false;
            this.xrTableCell29.Weight = 0.20290247599283853D;
            // 
            // xrLabel165
            // 
            this.xrLabel165.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel165.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel165.Multiline = true;
            this.xrLabel165.Name = "xrLabel165";
            this.xrLabel165.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel165.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel165.StylePriority.UseBorders = false;
            this.xrLabel165.StylePriority.UsePadding = false;
            // 
            // xrLabel166
            // 
            this.xrLabel166.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel166.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel166.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel166.Multiline = true;
            this.xrLabel166.Name = "xrLabel166";
            this.xrLabel166.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel166.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel166.StylePriority.UseBorderDashStyle = false;
            this.xrLabel166.StylePriority.UseBorders = false;
            this.xrLabel166.StylePriority.UsePadding = false;
            // 
            // xrLabel167
            // 
            this.xrLabel167.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel167.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel167.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel167.Multiline = true;
            this.xrLabel167.Name = "xrLabel167";
            this.xrLabel167.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel167.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel167.StylePriority.UseBorderDashStyle = false;
            this.xrLabel167.StylePriority.UseBorders = false;
            this.xrLabel167.StylePriority.UsePadding = false;
            // 
            // xrLabel168
            // 
            this.xrLabel168.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel168.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel168.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel168.Multiline = true;
            this.xrLabel168.Name = "xrLabel168";
            this.xrLabel168.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel168.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel168.StylePriority.UseBorderDashStyle = false;
            this.xrLabel168.StylePriority.UseBorders = false;
            this.xrLabel168.StylePriority.UsePadding = false;
            // 
            // xrLabel169
            // 
            this.xrLabel169.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel169.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel169.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel169.Multiline = true;
            this.xrLabel169.Name = "xrLabel169";
            this.xrLabel169.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel169.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel169.StylePriority.UseBorderDashStyle = false;
            this.xrLabel169.StylePriority.UseBorders = false;
            this.xrLabel169.StylePriority.UsePadding = false;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell30.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel170,
            this.xrLabel171,
            this.xrLabel172,
            this.xrLabel173,
            this.xrLabel174});
            this.xrTableCell30.Multiline = true;
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.StylePriority.UseBorders = false;
            this.xrTableCell30.Weight = 0.20290247599283853D;
            // 
            // xrLabel170
            // 
            this.xrLabel170.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel170.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel170.Multiline = true;
            this.xrLabel170.Name = "xrLabel170";
            this.xrLabel170.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel170.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel170.StylePriority.UseBorders = false;
            this.xrLabel170.StylePriority.UsePadding = false;
            // 
            // xrLabel171
            // 
            this.xrLabel171.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel171.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel171.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel171.Multiline = true;
            this.xrLabel171.Name = "xrLabel171";
            this.xrLabel171.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel171.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel171.StylePriority.UseBorderDashStyle = false;
            this.xrLabel171.StylePriority.UseBorders = false;
            this.xrLabel171.StylePriority.UsePadding = false;
            // 
            // xrLabel172
            // 
            this.xrLabel172.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel172.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel172.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel172.Multiline = true;
            this.xrLabel172.Name = "xrLabel172";
            this.xrLabel172.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel172.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel172.StylePriority.UseBorderDashStyle = false;
            this.xrLabel172.StylePriority.UseBorders = false;
            this.xrLabel172.StylePriority.UsePadding = false;
            // 
            // xrLabel173
            // 
            this.xrLabel173.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel173.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel173.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel173.Multiline = true;
            this.xrLabel173.Name = "xrLabel173";
            this.xrLabel173.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel173.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel173.StylePriority.UseBorderDashStyle = false;
            this.xrLabel173.StylePriority.UseBorders = false;
            this.xrLabel173.StylePriority.UsePadding = false;
            // 
            // xrLabel174
            // 
            this.xrLabel174.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel174.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel174.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel174.Multiline = true;
            this.xrLabel174.Name = "xrLabel174";
            this.xrLabel174.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel174.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel174.StylePriority.UseBorderDashStyle = false;
            this.xrLabel174.StylePriority.UseBorders = false;
            this.xrLabel174.StylePriority.UsePadding = false;
            // 
            // xrTable3
            // 
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(9.155273E-05F, 15.12346F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.SizeF = new System.Drawing.SizeF(372.019F, 74.11594F);
            this.xrTable3.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrTable3_BeforePrint);
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell13,
            this.xrTableCell14,
            this.xrTableCell15,
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell7.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel71,
            this.xrLabel70,
            this.xrLabel69,
            this.xrLabel68,
            this.xrLabel67});
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.Weight = 0.20290247599283853D;
            // 
            // xrLabel71
            // 
            this.xrLabel71.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel71.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel71.Multiline = true;
            this.xrLabel71.Name = "xrLabel71";
            this.xrLabel71.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel71.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel71.StylePriority.UseBorders = false;
            this.xrLabel71.StylePriority.UsePadding = false;
            // 
            // xrLabel70
            // 
            this.xrLabel70.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel70.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel70.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel70.Multiline = true;
            this.xrLabel70.Name = "xrLabel70";
            this.xrLabel70.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel70.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel70.StylePriority.UseBorderDashStyle = false;
            this.xrLabel70.StylePriority.UseBorders = false;
            this.xrLabel70.StylePriority.UsePadding = false;
            // 
            // xrLabel69
            // 
            this.xrLabel69.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel69.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel69.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel69.Multiline = true;
            this.xrLabel69.Name = "xrLabel69";
            this.xrLabel69.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel69.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel69.StylePriority.UseBorderDashStyle = false;
            this.xrLabel69.StylePriority.UseBorders = false;
            this.xrLabel69.StylePriority.UsePadding = false;
            // 
            // xrLabel68
            // 
            this.xrLabel68.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel68.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel68.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel68.Multiline = true;
            this.xrLabel68.Name = "xrLabel68";
            this.xrLabel68.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel68.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel68.StylePriority.UseBorderDashStyle = false;
            this.xrLabel68.StylePriority.UseBorders = false;
            this.xrLabel68.StylePriority.UsePadding = false;
            // 
            // xrLabel67
            // 
            this.xrLabel67.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel67.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel67.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel67.Multiline = true;
            this.xrLabel67.Name = "xrLabel67";
            this.xrLabel67.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel67.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel67.StylePriority.UseBorderDashStyle = false;
            this.xrLabel67.StylePriority.UseBorders = false;
            this.xrLabel67.StylePriority.UsePadding = false;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell8.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel72,
            this.xrLabel73,
            this.xrLabel74,
            this.xrLabel75,
            this.xrLabel76});
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.Weight = 0.20290247599283853D;
            // 
            // xrLabel72
            // 
            this.xrLabel72.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel72.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel72.Multiline = true;
            this.xrLabel72.Name = "xrLabel72";
            this.xrLabel72.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel72.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel72.StylePriority.UseBorders = false;
            this.xrLabel72.StylePriority.UsePadding = false;
            // 
            // xrLabel73
            // 
            this.xrLabel73.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel73.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel73.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel73.Multiline = true;
            this.xrLabel73.Name = "xrLabel73";
            this.xrLabel73.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel73.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel73.StylePriority.UseBorderDashStyle = false;
            this.xrLabel73.StylePriority.UseBorders = false;
            this.xrLabel73.StylePriority.UsePadding = false;
            // 
            // xrLabel74
            // 
            this.xrLabel74.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel74.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel74.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel74.Multiline = true;
            this.xrLabel74.Name = "xrLabel74";
            this.xrLabel74.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel74.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel74.StylePriority.UseBorderDashStyle = false;
            this.xrLabel74.StylePriority.UseBorders = false;
            this.xrLabel74.StylePriority.UsePadding = false;
            // 
            // xrLabel75
            // 
            this.xrLabel75.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel75.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel75.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel75.Multiline = true;
            this.xrLabel75.Name = "xrLabel75";
            this.xrLabel75.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel75.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel75.StylePriority.UseBorderDashStyle = false;
            this.xrLabel75.StylePriority.UseBorders = false;
            this.xrLabel75.StylePriority.UsePadding = false;
            // 
            // xrLabel76
            // 
            this.xrLabel76.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel76.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel76.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel76.Multiline = true;
            this.xrLabel76.Name = "xrLabel76";
            this.xrLabel76.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel76.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel76.StylePriority.UseBorderDashStyle = false;
            this.xrLabel76.StylePriority.UseBorders = false;
            this.xrLabel76.StylePriority.UsePadding = false;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell9.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel77,
            this.xrLabel78,
            this.xrLabel79,
            this.xrLabel80,
            this.xrLabel81});
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StylePriority.UseBorders = false;
            this.xrTableCell9.Weight = 0.20290247599283853D;
            // 
            // xrLabel77
            // 
            this.xrLabel77.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel77.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel77.Multiline = true;
            this.xrLabel77.Name = "xrLabel77";
            this.xrLabel77.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel77.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel77.StylePriority.UseBorders = false;
            this.xrLabel77.StylePriority.UsePadding = false;
            // 
            // xrLabel78
            // 
            this.xrLabel78.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel78.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel78.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel78.Multiline = true;
            this.xrLabel78.Name = "xrLabel78";
            this.xrLabel78.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel78.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel78.StylePriority.UseBorderDashStyle = false;
            this.xrLabel78.StylePriority.UseBorders = false;
            this.xrLabel78.StylePriority.UsePadding = false;
            // 
            // xrLabel79
            // 
            this.xrLabel79.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel79.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel79.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel79.Multiline = true;
            this.xrLabel79.Name = "xrLabel79";
            this.xrLabel79.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel79.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel79.StylePriority.UseBorderDashStyle = false;
            this.xrLabel79.StylePriority.UseBorders = false;
            this.xrLabel79.StylePriority.UsePadding = false;
            // 
            // xrLabel80
            // 
            this.xrLabel80.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel80.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel80.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel80.Multiline = true;
            this.xrLabel80.Name = "xrLabel80";
            this.xrLabel80.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel80.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel80.StylePriority.UseBorderDashStyle = false;
            this.xrLabel80.StylePriority.UseBorders = false;
            this.xrLabel80.StylePriority.UsePadding = false;
            // 
            // xrLabel81
            // 
            this.xrLabel81.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel81.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel81.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel81.Multiline = true;
            this.xrLabel81.Name = "xrLabel81";
            this.xrLabel81.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel81.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel81.StylePriority.UseBorderDashStyle = false;
            this.xrLabel81.StylePriority.UseBorders = false;
            this.xrLabel81.StylePriority.UsePadding = false;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell10.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel82,
            this.xrLabel83,
            this.xrLabel84,
            this.xrLabel85,
            this.xrLabel86});
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseBorders = false;
            this.xrTableCell10.Weight = 0.20290247599283853D;
            // 
            // xrLabel82
            // 
            this.xrLabel82.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel82.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel82.Multiline = true;
            this.xrLabel82.Name = "xrLabel82";
            this.xrLabel82.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel82.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel82.StylePriority.UseBorders = false;
            this.xrLabel82.StylePriority.UsePadding = false;
            // 
            // xrLabel83
            // 
            this.xrLabel83.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel83.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel83.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel83.Multiline = true;
            this.xrLabel83.Name = "xrLabel83";
            this.xrLabel83.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel83.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel83.StylePriority.UseBorderDashStyle = false;
            this.xrLabel83.StylePriority.UseBorders = false;
            this.xrLabel83.StylePriority.UsePadding = false;
            // 
            // xrLabel84
            // 
            this.xrLabel84.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel84.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel84.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel84.Multiline = true;
            this.xrLabel84.Name = "xrLabel84";
            this.xrLabel84.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel84.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel84.StylePriority.UseBorderDashStyle = false;
            this.xrLabel84.StylePriority.UseBorders = false;
            this.xrLabel84.StylePriority.UsePadding = false;
            // 
            // xrLabel85
            // 
            this.xrLabel85.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel85.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel85.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel85.Multiline = true;
            this.xrLabel85.Name = "xrLabel85";
            this.xrLabel85.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel85.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel85.StylePriority.UseBorderDashStyle = false;
            this.xrLabel85.StylePriority.UseBorders = false;
            this.xrLabel85.StylePriority.UsePadding = false;
            // 
            // xrLabel86
            // 
            this.xrLabel86.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel86.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel86.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel86.Multiline = true;
            this.xrLabel86.Name = "xrLabel86";
            this.xrLabel86.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel86.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel86.StylePriority.UseBorderDashStyle = false;
            this.xrLabel86.StylePriority.UseBorders = false;
            this.xrLabel86.StylePriority.UsePadding = false;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell11.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel87,
            this.xrLabel88,
            this.xrLabel89,
            this.xrLabel90,
            this.xrLabel91});
            this.xrTableCell11.Multiline = true;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseBorders = false;
            this.xrTableCell11.Weight = 0.20290247599283853D;
            // 
            // xrLabel87
            // 
            this.xrLabel87.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel87.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel87.Multiline = true;
            this.xrLabel87.Name = "xrLabel87";
            this.xrLabel87.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel87.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel87.StylePriority.UseBorders = false;
            this.xrLabel87.StylePriority.UsePadding = false;
            // 
            // xrLabel88
            // 
            this.xrLabel88.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel88.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel88.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel88.Multiline = true;
            this.xrLabel88.Name = "xrLabel88";
            this.xrLabel88.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel88.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel88.StylePriority.UseBorderDashStyle = false;
            this.xrLabel88.StylePriority.UseBorders = false;
            this.xrLabel88.StylePriority.UsePadding = false;
            // 
            // xrLabel89
            // 
            this.xrLabel89.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel89.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel89.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel89.Multiline = true;
            this.xrLabel89.Name = "xrLabel89";
            this.xrLabel89.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel89.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel89.StylePriority.UseBorderDashStyle = false;
            this.xrLabel89.StylePriority.UseBorders = false;
            this.xrLabel89.StylePriority.UsePadding = false;
            // 
            // xrLabel90
            // 
            this.xrLabel90.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel90.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel90.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel90.Multiline = true;
            this.xrLabel90.Name = "xrLabel90";
            this.xrLabel90.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel90.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel90.StylePriority.UseBorderDashStyle = false;
            this.xrLabel90.StylePriority.UseBorders = false;
            this.xrLabel90.StylePriority.UsePadding = false;
            // 
            // xrLabel91
            // 
            this.xrLabel91.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel91.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel91.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel91.Multiline = true;
            this.xrLabel91.Name = "xrLabel91";
            this.xrLabel91.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel91.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel91.StylePriority.UseBorderDashStyle = false;
            this.xrLabel91.StylePriority.UseBorders = false;
            this.xrLabel91.StylePriority.UsePadding = false;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell12.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel92,
            this.xrLabel93,
            this.xrLabel94,
            this.xrLabel95,
            this.xrLabel96});
            this.xrTableCell12.Multiline = true;
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.StylePriority.UseBorders = false;
            this.xrTableCell12.Weight = 0.20290247599283853D;
            // 
            // xrLabel92
            // 
            this.xrLabel92.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel92.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel92.Multiline = true;
            this.xrLabel92.Name = "xrLabel92";
            this.xrLabel92.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel92.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel92.StylePriority.UseBorders = false;
            this.xrLabel92.StylePriority.UsePadding = false;
            // 
            // xrLabel93
            // 
            this.xrLabel93.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel93.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel93.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel93.Multiline = true;
            this.xrLabel93.Name = "xrLabel93";
            this.xrLabel93.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel93.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel93.StylePriority.UseBorderDashStyle = false;
            this.xrLabel93.StylePriority.UseBorders = false;
            this.xrLabel93.StylePriority.UsePadding = false;
            // 
            // xrLabel94
            // 
            this.xrLabel94.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel94.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel94.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel94.Multiline = true;
            this.xrLabel94.Name = "xrLabel94";
            this.xrLabel94.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel94.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel94.StylePriority.UseBorderDashStyle = false;
            this.xrLabel94.StylePriority.UseBorders = false;
            this.xrLabel94.StylePriority.UsePadding = false;
            // 
            // xrLabel95
            // 
            this.xrLabel95.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel95.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel95.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel95.Multiline = true;
            this.xrLabel95.Name = "xrLabel95";
            this.xrLabel95.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel95.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel95.StylePriority.UseBorderDashStyle = false;
            this.xrLabel95.StylePriority.UseBorders = false;
            this.xrLabel95.StylePriority.UsePadding = false;
            // 
            // xrLabel96
            // 
            this.xrLabel96.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel96.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel96.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel96.Multiline = true;
            this.xrLabel96.Name = "xrLabel96";
            this.xrLabel96.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel96.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel96.StylePriority.UseBorderDashStyle = false;
            this.xrLabel96.StylePriority.UseBorders = false;
            this.xrLabel96.StylePriority.UsePadding = false;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell13.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel97,
            this.xrLabel98,
            this.xrLabel99,
            this.xrLabel100,
            this.xrLabel101});
            this.xrTableCell13.Multiline = true;
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StylePriority.UseBorders = false;
            this.xrTableCell13.Weight = 0.20290247599283853D;
            // 
            // xrLabel97
            // 
            this.xrLabel97.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel97.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel97.Multiline = true;
            this.xrLabel97.Name = "xrLabel97";
            this.xrLabel97.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel97.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel97.StylePriority.UseBorders = false;
            this.xrLabel97.StylePriority.UsePadding = false;
            // 
            // xrLabel98
            // 
            this.xrLabel98.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel98.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel98.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel98.Multiline = true;
            this.xrLabel98.Name = "xrLabel98";
            this.xrLabel98.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel98.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel98.StylePriority.UseBorderDashStyle = false;
            this.xrLabel98.StylePriority.UseBorders = false;
            this.xrLabel98.StylePriority.UsePadding = false;
            // 
            // xrLabel99
            // 
            this.xrLabel99.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel99.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel99.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel99.Multiline = true;
            this.xrLabel99.Name = "xrLabel99";
            this.xrLabel99.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel99.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel99.StylePriority.UseBorderDashStyle = false;
            this.xrLabel99.StylePriority.UseBorders = false;
            this.xrLabel99.StylePriority.UsePadding = false;
            // 
            // xrLabel100
            // 
            this.xrLabel100.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel100.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel100.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel100.Multiline = true;
            this.xrLabel100.Name = "xrLabel100";
            this.xrLabel100.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel100.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel100.StylePriority.UseBorderDashStyle = false;
            this.xrLabel100.StylePriority.UseBorders = false;
            this.xrLabel100.StylePriority.UsePadding = false;
            // 
            // xrLabel101
            // 
            this.xrLabel101.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel101.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel101.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel101.Multiline = true;
            this.xrLabel101.Name = "xrLabel101";
            this.xrLabel101.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel101.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel101.StylePriority.UseBorderDashStyle = false;
            this.xrLabel101.StylePriority.UseBorders = false;
            this.xrLabel101.StylePriority.UsePadding = false;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell14.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel102,
            this.xrLabel103,
            this.xrLabel104,
            this.xrLabel105,
            this.xrLabel106});
            this.xrTableCell14.Multiline = true;
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseBorders = false;
            this.xrTableCell14.Weight = 0.20290247599283853D;
            // 
            // xrLabel102
            // 
            this.xrLabel102.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel102.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel102.Multiline = true;
            this.xrLabel102.Name = "xrLabel102";
            this.xrLabel102.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel102.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel102.StylePriority.UseBorders = false;
            this.xrLabel102.StylePriority.UsePadding = false;
            // 
            // xrLabel103
            // 
            this.xrLabel103.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel103.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel103.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel103.Multiline = true;
            this.xrLabel103.Name = "xrLabel103";
            this.xrLabel103.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel103.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel103.StylePriority.UseBorderDashStyle = false;
            this.xrLabel103.StylePriority.UseBorders = false;
            this.xrLabel103.StylePriority.UsePadding = false;
            // 
            // xrLabel104
            // 
            this.xrLabel104.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel104.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel104.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel104.Multiline = true;
            this.xrLabel104.Name = "xrLabel104";
            this.xrLabel104.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel104.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel104.StylePriority.UseBorderDashStyle = false;
            this.xrLabel104.StylePriority.UseBorders = false;
            this.xrLabel104.StylePriority.UsePadding = false;
            // 
            // xrLabel105
            // 
            this.xrLabel105.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel105.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel105.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel105.Multiline = true;
            this.xrLabel105.Name = "xrLabel105";
            this.xrLabel105.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel105.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel105.StylePriority.UseBorderDashStyle = false;
            this.xrLabel105.StylePriority.UseBorders = false;
            this.xrLabel105.StylePriority.UsePadding = false;
            // 
            // xrLabel106
            // 
            this.xrLabel106.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel106.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel106.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel106.Multiline = true;
            this.xrLabel106.Name = "xrLabel106";
            this.xrLabel106.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel106.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel106.StylePriority.UseBorderDashStyle = false;
            this.xrLabel106.StylePriority.UseBorders = false;
            this.xrLabel106.StylePriority.UsePadding = false;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell15.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel107,
            this.xrLabel108,
            this.xrLabel109,
            this.xrLabel110,
            this.xrLabel111});
            this.xrTableCell15.Multiline = true;
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseBorders = false;
            this.xrTableCell15.Weight = 0.20290247599283853D;
            // 
            // xrLabel107
            // 
            this.xrLabel107.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel107.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel107.Multiline = true;
            this.xrLabel107.Name = "xrLabel107";
            this.xrLabel107.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel107.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel107.StylePriority.UseBorders = false;
            this.xrLabel107.StylePriority.UsePadding = false;
            // 
            // xrLabel108
            // 
            this.xrLabel108.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel108.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel108.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel108.Multiline = true;
            this.xrLabel108.Name = "xrLabel108";
            this.xrLabel108.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel108.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel108.StylePriority.UseBorderDashStyle = false;
            this.xrLabel108.StylePriority.UseBorders = false;
            this.xrLabel108.StylePriority.UsePadding = false;
            // 
            // xrLabel109
            // 
            this.xrLabel109.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel109.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel109.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel109.Multiline = true;
            this.xrLabel109.Name = "xrLabel109";
            this.xrLabel109.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel109.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel109.StylePriority.UseBorderDashStyle = false;
            this.xrLabel109.StylePriority.UseBorders = false;
            this.xrLabel109.StylePriority.UsePadding = false;
            // 
            // xrLabel110
            // 
            this.xrLabel110.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel110.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel110.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel110.Multiline = true;
            this.xrLabel110.Name = "xrLabel110";
            this.xrLabel110.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel110.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel110.StylePriority.UseBorderDashStyle = false;
            this.xrLabel110.StylePriority.UseBorders = false;
            this.xrLabel110.StylePriority.UsePadding = false;
            // 
            // xrLabel111
            // 
            this.xrLabel111.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel111.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel111.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel111.Multiline = true;
            this.xrLabel111.Name = "xrLabel111";
            this.xrLabel111.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel111.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel111.StylePriority.UseBorderDashStyle = false;
            this.xrLabel111.StylePriority.UseBorders = false;
            this.xrLabel111.StylePriority.UsePadding = false;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell16.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel112,
            this.xrLabel113,
            this.xrLabel114,
            this.xrLabel115,
            this.xrLabel116});
            this.xrTableCell16.Multiline = true;
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseBorders = false;
            this.xrTableCell16.Weight = 0.20290247599283853D;
            // 
            // xrLabel112
            // 
            this.xrLabel112.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel112.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel112.Multiline = true;
            this.xrLabel112.Name = "xrLabel112";
            this.xrLabel112.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel112.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel112.StylePriority.UseBorders = false;
            this.xrLabel112.StylePriority.UsePadding = false;
            // 
            // xrLabel113
            // 
            this.xrLabel113.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel113.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel113.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel113.Multiline = true;
            this.xrLabel113.Name = "xrLabel113";
            this.xrLabel113.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel113.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel113.StylePriority.UseBorderDashStyle = false;
            this.xrLabel113.StylePriority.UseBorders = false;
            this.xrLabel113.StylePriority.UsePadding = false;
            // 
            // xrLabel114
            // 
            this.xrLabel114.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel114.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel114.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel114.Multiline = true;
            this.xrLabel114.Name = "xrLabel114";
            this.xrLabel114.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel114.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel114.StylePriority.UseBorderDashStyle = false;
            this.xrLabel114.StylePriority.UseBorders = false;
            this.xrLabel114.StylePriority.UsePadding = false;
            // 
            // xrLabel115
            // 
            this.xrLabel115.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel115.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel115.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel115.Multiline = true;
            this.xrLabel115.Name = "xrLabel115";
            this.xrLabel115.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel115.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel115.StylePriority.UseBorderDashStyle = false;
            this.xrLabel115.StylePriority.UseBorders = false;
            this.xrLabel115.StylePriority.UsePadding = false;
            // 
            // xrLabel116
            // 
            this.xrLabel116.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel116.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel116.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel116.Multiline = true;
            this.xrLabel116.Name = "xrLabel116";
            this.xrLabel116.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel116.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel116.StylePriority.UseBorderDashStyle = false;
            this.xrLabel116.StylePriority.UseBorders = false;
            this.xrLabel116.StylePriority.UsePadding = false;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell17.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel117,
            this.xrLabel118,
            this.xrLabel119,
            this.xrLabel120,
            this.xrLabel121});
            this.xrTableCell17.Multiline = true;
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseBorders = false;
            this.xrTableCell17.Weight = 0.20290247599283853D;
            // 
            // xrLabel117
            // 
            this.xrLabel117.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel117.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel117.Multiline = true;
            this.xrLabel117.Name = "xrLabel117";
            this.xrLabel117.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel117.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel117.StylePriority.UseBorders = false;
            this.xrLabel117.StylePriority.UsePadding = false;
            // 
            // xrLabel118
            // 
            this.xrLabel118.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel118.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel118.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel118.Multiline = true;
            this.xrLabel118.Name = "xrLabel118";
            this.xrLabel118.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel118.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel118.StylePriority.UseBorderDashStyle = false;
            this.xrLabel118.StylePriority.UseBorders = false;
            this.xrLabel118.StylePriority.UsePadding = false;
            // 
            // xrLabel119
            // 
            this.xrLabel119.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel119.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel119.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel119.Multiline = true;
            this.xrLabel119.Name = "xrLabel119";
            this.xrLabel119.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel119.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel119.StylePriority.UseBorderDashStyle = false;
            this.xrLabel119.StylePriority.UseBorders = false;
            this.xrLabel119.StylePriority.UsePadding = false;
            // 
            // xrLabel120
            // 
            this.xrLabel120.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel120.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel120.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel120.Multiline = true;
            this.xrLabel120.Name = "xrLabel120";
            this.xrLabel120.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel120.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel120.StylePriority.UseBorderDashStyle = false;
            this.xrLabel120.StylePriority.UseBorders = false;
            this.xrLabel120.StylePriority.UsePadding = false;
            // 
            // xrLabel121
            // 
            this.xrLabel121.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel121.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel121.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel121.Multiline = true;
            this.xrLabel121.Name = "xrLabel121";
            this.xrLabel121.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel121.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel121.StylePriority.UseBorderDashStyle = false;
            this.xrLabel121.StylePriority.UseBorders = false;
            this.xrLabel121.StylePriority.UsePadding = false;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell18.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel122,
            this.xrLabel123,
            this.xrLabel124,
            this.xrLabel125,
            this.xrLabel126});
            this.xrTableCell18.Multiline = true;
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.StylePriority.UseBorders = false;
            this.xrTableCell18.Weight = 0.20290247599283853D;
            // 
            // xrLabel122
            // 
            this.xrLabel122.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel122.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.99989F);
            this.xrLabel122.Multiline = true;
            this.xrLabel122.Name = "xrLabel122";
            this.xrLabel122.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel122.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel122.StylePriority.UseBorders = false;
            this.xrLabel122.StylePriority.UsePadding = false;
            // 
            // xrLabel123
            // 
            this.xrLabel123.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel123.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel123.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.99992F);
            this.xrLabel123.Multiline = true;
            this.xrLabel123.Name = "xrLabel123";
            this.xrLabel123.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel123.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel123.StylePriority.UseBorderDashStyle = false;
            this.xrLabel123.StylePriority.UseBorders = false;
            this.xrLabel123.StylePriority.UsePadding = false;
            // 
            // xrLabel124
            // 
            this.xrLabel124.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel124.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel124.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.99994F);
            this.xrLabel124.Multiline = true;
            this.xrLabel124.Name = "xrLabel124";
            this.xrLabel124.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel124.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel124.StylePriority.UseBorderDashStyle = false;
            this.xrLabel124.StylePriority.UseBorders = false;
            this.xrLabel124.StylePriority.UsePadding = false;
            // 
            // xrLabel125
            // 
            this.xrLabel125.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel125.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel125.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.99997F);
            this.xrLabel125.Multiline = true;
            this.xrLabel125.Name = "xrLabel125";
            this.xrLabel125.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel125.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel125.StylePriority.UseBorderDashStyle = false;
            this.xrLabel125.StylePriority.UseBorders = false;
            this.xrLabel125.StylePriority.UsePadding = false;
            // 
            // xrLabel126
            // 
            this.xrLabel126.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel126.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel126.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel126.Multiline = true;
            this.xrLabel126.Name = "xrLabel126";
            this.xrLabel126.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel126.SizeF = new System.Drawing.SizeF(31.00158F, 14.99997F);
            this.xrLabel126.StylePriority.UseBorderDashStyle = false;
            this.xrLabel126.StylePriority.UseBorders = false;
            this.xrLabel126.StylePriority.UsePadding = false;
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(372.0191F, 15.12346F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.xrTableCell6});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel311,
            this.xrLabel310,
            this.xrLabel309,
            this.xrLabel308,
            this.xrLabel307});
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.Weight = 1.8600953674316405D;
            // 
            // xrLabel311
            // 
            this.xrLabel311.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel311.LocationFloat = new DevExpress.Utils.PointFloat(137.6855F, 0F);
            this.xrLabel311.Multiline = true;
            this.xrLabel311.Name = "xrLabel311";
            this.xrLabel311.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel311.SizeF = new System.Drawing.SizeF(31.92136F, 15.12345F);
            this.xrLabel311.StylePriority.UseBorders = false;
            this.xrLabel311.StylePriority.UseTextAlignment = false;
            this.xrLabel311.Text = "50";
            this.xrLabel311.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel310
            // 
            this.xrLabel310.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel310.LocationFloat = new DevExpress.Utils.PointFloat(105.7641F, 0.6172709F);
            this.xrLabel310.Multiline = true;
            this.xrLabel310.Name = "xrLabel310";
            this.xrLabel310.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel310.SizeF = new System.Drawing.SizeF(31.92136F, 15.12345F);
            this.xrLabel310.StylePriority.UseBorders = false;
            this.xrLabel310.StylePriority.UseTextAlignment = false;
            this.xrLabel310.Text = "40";
            this.xrLabel310.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel309
            // 
            this.xrLabel309.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel309.LocationFloat = new DevExpress.Utils.PointFloat(73.84271F, 0F);
            this.xrLabel309.Multiline = true;
            this.xrLabel309.Name = "xrLabel309";
            this.xrLabel309.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel309.SizeF = new System.Drawing.SizeF(31.92136F, 15.12345F);
            this.xrLabel309.StylePriority.UseBorders = false;
            this.xrLabel309.StylePriority.UseTextAlignment = false;
            this.xrLabel309.Text = "30";
            this.xrLabel309.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel308
            // 
            this.xrLabel308.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel308.LocationFloat = new DevExpress.Utils.PointFloat(41.92139F, 0.6172621F);
            this.xrLabel308.Multiline = true;
            this.xrLabel308.Name = "xrLabel308";
            this.xrLabel308.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel308.SizeF = new System.Drawing.SizeF(31.92136F, 15.12345F);
            this.xrLabel308.StylePriority.UseBorders = false;
            this.xrLabel308.StylePriority.UseTextAlignment = false;
            this.xrLabel308.Text = "20";
            this.xrLabel308.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel307
            // 
            this.xrLabel307.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel307.LocationFloat = new DevExpress.Utils.PointFloat(10.00006F, 8.769422E-06F);
            this.xrLabel307.Multiline = true;
            this.xrLabel307.Name = "xrLabel307";
            this.xrLabel307.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel307.SizeF = new System.Drawing.SizeF(31.92136F, 15.12345F);
            this.xrLabel307.StylePriority.UseBorders = false;
            this.xrLabel307.StylePriority.UseTextAlignment = false;
            this.xrLabel307.Text = "10";
            this.xrLabel307.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel312,
            this.xrLabel313,
            this.xrLabel314,
            this.xrLabel315,
            this.xrLabel316});
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.Weight = 1.8600953674316405D;
            // 
            // xrLabel312
            // 
            this.xrLabel312.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel312.LocationFloat = new DevExpress.Utils.PointFloat(10.00006F, 8.769422E-06F);
            this.xrLabel312.Multiline = true;
            this.xrLabel312.Name = "xrLabel312";
            this.xrLabel312.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel312.SizeF = new System.Drawing.SizeF(31.92136F, 15.12345F);
            this.xrLabel312.StylePriority.UseBorders = false;
            this.xrLabel312.StylePriority.UseTextAlignment = false;
            this.xrLabel312.Text = "10";
            this.xrLabel312.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel313
            // 
            this.xrLabel313.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel313.LocationFloat = new DevExpress.Utils.PointFloat(41.92139F, 0.6172621F);
            this.xrLabel313.Multiline = true;
            this.xrLabel313.Name = "xrLabel313";
            this.xrLabel313.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel313.SizeF = new System.Drawing.SizeF(31.92136F, 15.12345F);
            this.xrLabel313.StylePriority.UseBorders = false;
            this.xrLabel313.StylePriority.UseTextAlignment = false;
            this.xrLabel313.Text = "20";
            this.xrLabel313.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel314
            // 
            this.xrLabel314.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel314.LocationFloat = new DevExpress.Utils.PointFloat(73.84271F, 0F);
            this.xrLabel314.Multiline = true;
            this.xrLabel314.Name = "xrLabel314";
            this.xrLabel314.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel314.SizeF = new System.Drawing.SizeF(31.92136F, 15.12345F);
            this.xrLabel314.StylePriority.UseBorders = false;
            this.xrLabel314.StylePriority.UseTextAlignment = false;
            this.xrLabel314.Text = "30";
            this.xrLabel314.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel315
            // 
            this.xrLabel315.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel315.LocationFloat = new DevExpress.Utils.PointFloat(105.7641F, 0.6172709F);
            this.xrLabel315.Multiline = true;
            this.xrLabel315.Name = "xrLabel315";
            this.xrLabel315.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel315.SizeF = new System.Drawing.SizeF(31.92136F, 15.12345F);
            this.xrLabel315.StylePriority.UseBorders = false;
            this.xrLabel315.StylePriority.UseTextAlignment = false;
            this.xrLabel315.Text = "40";
            this.xrLabel315.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel316
            // 
            this.xrLabel316.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel316.LocationFloat = new DevExpress.Utils.PointFloat(137.6855F, 0F);
            this.xrLabel316.Multiline = true;
            this.xrLabel316.Name = "xrLabel316";
            this.xrLabel316.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel316.SizeF = new System.Drawing.SizeF(31.92136F, 15.12345F);
            this.xrLabel316.StylePriority.UseBorders = false;
            this.xrLabel316.StylePriority.UseTextAlignment = false;
            this.xrLabel316.Text = "50";
            this.xrLabel316.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel601,
            this.xrPanel4,
            this.xrLabel317});
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell4.Weight = 0.42871646628333338D;
            // 
            // xrLabel601
            // 
            this.xrLabel601.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel601.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel601.LocationFloat = new DevExpress.Utils.PointFloat(0.0003051758F, 663.0813F);
            this.xrLabel601.Multiline = true;
            this.xrLabel601.Name = "xrLabel601";
            this.xrLabel601.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel601.SizeF = new System.Drawing.SizeF(77.88721F, 58F);
            this.xrLabel601.StylePriority.UseBorders = false;
            this.xrLabel601.StylePriority.UseFont = false;
            this.xrLabel601.StylePriority.UseTextAlignment = false;
            this.xrLabel601.Text = "Tổng thời gian gây mê";
            this.xrLabel601.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrPanel4
            // 
            this.xrPanel4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrPanel4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel456});
            this.xrPanel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.62962F);
            this.xrPanel4.Name = "xrPanel4";
            this.xrPanel4.SizeF = new System.Drawing.SizeF(77.88727F, 438F);
            this.xrPanel4.StylePriority.UseBorders = false;
            // 
            // xrLabel456
            // 
            this.xrLabel456.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel456.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel456.LocationFloat = new DevExpress.Utils.PointFloat(0.0001831055F, 405.8423F);
            this.xrLabel456.Multiline = true;
            this.xrLabel456.Name = "xrLabel456";
            this.xrLabel456.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel456.SizeF = new System.Drawing.SizeF(77.88721F, 30.38589F);
            this.xrLabel456.StylePriority.UseBorders = false;
            this.xrLabel456.StylePriority.UseFont = false;
            this.xrLabel456.StylePriority.UseTextAlignment = false;
            this.xrLabel456.Text = "Tổng cộng";
            this.xrLabel456.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel317
            // 
            this.xrLabel317.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel317.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel317.LocationFloat = new DevExpress.Utils.PointFloat(6.103516E-05F, 0.6172696F);
            this.xrLabel317.Multiline = true;
            this.xrLabel317.Name = "xrLabel317";
            this.xrLabel317.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel317.SizeF = new System.Drawing.SizeF(77.88733F, 44.01236F);
            this.xrLabel317.StylePriority.UseBorders = false;
            this.xrLabel317.StylePriority.UseFont = false;
            this.xrLabel317.StylePriority.UseTextAlignment = false;
            this.xrLabel317.Text = "Nhận xét và kết luận";
            this.xrLabel317.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 47.41512F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel2,
            this.xrPanel1});
            this.ReportHeader.HeightF = 231.7802F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrPanel2
            // 
            this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel46,
            this.xrLabel45,
            this.xrLabel44,
            this.xrLabel43,
            this.xrLabel42,
            this.xrLabel41,
            this.xrLabel40,
            this.xrLabel39,
            this.xrLabel38,
            this.xrLabel37,
            this.xrLabel36,
            this.xrLabel35,
            this.xrLabel34,
            this.xrLabel33,
            this.xrLabel32,
            this.xrLabel31,
            this.xrLabel30,
            this.xrLabel29,
            this.xrLabel28,
            this.xrLabel27,
            this.xrLabel26,
            this.xrLabel25,
            this.xrLabel23,
            this.xrLabel24,
            this.xrLabel22,
            this.xrLabel21,
            this.xrLabel20,
            this.xrLabel19,
            this.xrLabel17,
            this.xrLabel18,
            this.xrLabel16,
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel13,
            this.xrCheckBox2,
            this.xrCheckBox1,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9});
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(0.2992028F, 69.99994F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.SizeF = new System.Drawing.SizeF(726.7007F, 161.7803F);
            // 
            // xrLabel46
            // 
            this.xrLabel46.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TacDung]")});
            this.xrLabel46.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel46.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel46.LocationFloat = new DevExpress.Utils.PointFloat(546.8133F, 138.0002F);
            this.xrLabel46.Multiline = true;
            this.xrLabel46.Name = "xrLabel46";
            this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel46.SizeF = new System.Drawing.SizeF(179.8876F, 23.00003F);
            this.xrLabel46.StylePriority.UseFont = false;
            this.xrLabel46.StylePriority.UseForeColor = false;
            this.xrLabel46.StylePriority.UseTextAlignment = false;
            this.xrLabel46.Text = "Phê , đê mê";
            this.xrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel45
            // 
            this.xrLabel45.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(483.1381F, 138.0002F);
            this.xrLabel45.Multiline = true;
            this.xrLabel45.Name = "xrLabel45";
            this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel45.SizeF = new System.Drawing.SizeF(63.67517F, 23.00003F);
            this.xrLabel45.StylePriority.UseFont = false;
            this.xrLabel45.StylePriority.UseTextAlignment = false;
            this.xrLabel45.Text = "Tác dụng:";
            this.xrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel44
            // 
            this.xrLabel44.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TienMe]")});
            this.xrLabel44.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel44.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(302.8416F, 138.0002F);
            this.xrLabel44.Multiline = true;
            this.xrLabel44.Name = "xrLabel44";
            this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel44.SizeF = new System.Drawing.SizeF(180.2964F, 23.00003F);
            this.xrLabel44.StylePriority.UseFont = false;
            this.xrLabel44.StylePriority.UseForeColor = false;
            this.xrLabel44.StylePriority.UseTextAlignment = false;
            this.xrLabel44.Text = "Môi hồng, chi ấm";
            this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel43
            // 
            this.xrLabel43.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(247.4998F, 138.0002F);
            this.xrLabel43.Multiline = true;
            this.xrLabel43.Name = "xrLabel43";
            this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel43.SizeF = new System.Drawing.SizeF(55.34186F, 23.00003F);
            this.xrLabel43.StylePriority.UseFont = false;
            this.xrLabel43.StylePriority.UseTextAlignment = false;
            this.xrLabel43.Text = "Tiền mê:";
            this.xrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel42
            // 
            this.xrLabel42.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Nam]")});
            this.xrLabel42.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel42.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(190.1282F, 138.0002F);
            this.xrLabel42.Multiline = true;
            this.xrLabel42.Name = "xrLabel42";
            this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel42.SizeF = new System.Drawing.SizeF(57.37161F, 23F);
            this.xrLabel42.StylePriority.UseFont = false;
            this.xrLabel42.StylePriority.UseForeColor = false;
            this.xrLabel42.StylePriority.UseTextAlignment = false;
            this.xrLabel42.Text = "2023";
            this.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel41
            // 
            this.xrLabel41.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(152.5641F, 138.0002F);
            this.xrLabel41.Multiline = true;
            this.xrLabel41.Name = "xrLabel41";
            this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel41.SizeF = new System.Drawing.SizeF(37.56409F, 23F);
            this.xrLabel41.StylePriority.UseFont = false;
            this.xrLabel41.StylePriority.UseTextAlignment = false;
            this.xrLabel41.Text = "Năm:";
            this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel40
            // 
            this.xrLabel40.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Thang]")});
            this.xrLabel40.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel40.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(128.8034F, 138.0002F);
            this.xrLabel40.Multiline = true;
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(23.76071F, 23F);
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.StylePriority.UseForeColor = false;
            this.xrLabel40.StylePriority.UseTextAlignment = false;
            this.xrLabel40.Text = "09";
            this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel39
            // 
            this.xrLabel39.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(77.3504F, 138.0002F);
            this.xrLabel39.Multiline = true;
            this.xrLabel39.Name = "xrLabel39";
            this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel39.SizeF = new System.Drawing.SizeF(51.45297F, 23F);
            this.xrLabel39.StylePriority.UseFont = false;
            this.xrLabel39.StylePriority.UseTextAlignment = false;
            this.xrLabel39.Text = "Tháng:";
            this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel38
            // 
            this.xrLabel38.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Ngay]")});
            this.xrLabel38.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel38.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(51.45299F, 138.0002F);
            this.xrLabel38.Multiline = true;
            this.xrLabel38.Name = "xrLabel38";
            this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel38.SizeF = new System.Drawing.SizeF(25.89742F, 23F);
            this.xrLabel38.StylePriority.UseFont = false;
            this.xrLabel38.StylePriority.UseForeColor = false;
            this.xrLabel38.StylePriority.UseTextAlignment = false;
            this.xrLabel38.Text = "11";
            this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel37
            // 
            this.xrLabel37.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(3.391504E-05F, 138.0002F);
            this.xrLabel37.Multiline = true;
            this.xrLabel37.Name = "xrLabel37";
            this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel37.SizeF = new System.Drawing.SizeF(51.45297F, 23F);
            this.xrLabel37.StylePriority.UseFont = false;
            this.xrLabel37.StylePriority.UseTextAlignment = false;
            this.xrLabel37.Text = "- Ngày:";
            this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel36
            // 
            this.xrLabel36.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BSGayMe]")});
            this.xrLabel36.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel36.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(447.2072F, 115.0002F);
            this.xrLabel36.Multiline = true;
            this.xrLabel36.Name = "xrLabel36";
            this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel36.SizeF = new System.Drawing.SizeF(279.4936F, 23.00002F);
            this.xrLabel36.StylePriority.UseFont = false;
            this.xrLabel36.StylePriority.UseForeColor = false;
            this.xrLabel36.StylePriority.UseTextAlignment = false;
            this.xrLabel36.Text = "Nguyễn Văn B";
            this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel35
            // 
            this.xrLabel35.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(365.2267F, 115.0002F);
            this.xrLabel35.Multiline = true;
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(81.45297F, 23.00003F);
            this.xrLabel35.StylePriority.UseFont = false;
            this.xrLabel35.StylePriority.UseTextAlignment = false;
            this.xrLabel35.Text = "BS Gây Mê:";
            this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel34
            // 
            this.xrLabel34.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BSPhauThuat]")});
            this.xrLabel34.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel34.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(102.0085F, 115.0002F);
            this.xrLabel34.Multiline = true;
            this.xrLabel34.Name = "xrLabel34";
            this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel34.SizeF = new System.Drawing.SizeF(263.2182F, 22.99995F);
            this.xrLabel34.StylePriority.UseFont = false;
            this.xrLabel34.StylePriority.UseForeColor = false;
            this.xrLabel34.StylePriority.UseTextAlignment = false;
            this.xrLabel34.Text = "Nguyễn Văn A";
            this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel33
            // 
            this.xrLabel33.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(3.391504E-05F, 115.0002F);
            this.xrLabel33.Multiline = true;
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(102.0085F, 23.00002F);
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.StylePriority.UseTextAlignment = false;
            this.xrLabel33.Text = "- BS Phẫu Thuật:";
            this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel32
            // 
            this.xrLabel32.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TuThe]")});
            this.xrLabel32.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel32.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(498.3759F, 69.00014F);
            this.xrLabel32.Multiline = true;
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(228.3249F, 23.00003F);
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.StylePriority.UseForeColor = false;
            this.xrLabel32.StylePriority.UseTextAlignment = false;
            this.xrLabel32.Text = "Xe đạp chổng ngược";
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel31
            // 
            this.xrLabel31.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(450.2563F, 69.00014F);
            this.xrLabel31.Multiline = true;
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(48.1196F, 23.00003F);
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.StylePriority.UseTextAlignment = false;
            this.xrLabel31.Text = "Tư thế:";
            this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel30
            // 
            this.xrLabel30.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PPVoCam]")});
            this.xrLabel30.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel30.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(137.5641F, 92.00017F);
            this.xrLabel30.Multiline = true;
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(589.1367F, 23.00002F);
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.StylePriority.UseForeColor = false;
            this.xrLabel30.StylePriority.UseTextAlignment = false;
            this.xrLabel30.Text = "Không cảm xúc - Hồ Quang Hiếu";
            this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel29
            // 
            this.xrLabel29.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(1.311302E-06F, 92.00014F);
            this.xrLabel29.Multiline = true;
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(137.5641F, 23.00002F);
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.StylePriority.UseTextAlignment = false;
            this.xrLabel29.Text = "- Phương pháp vô cảm:";
            this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel28
            // 
            this.xrLabel28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PPPhauThuat]")});
            this.xrLabel28.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel28.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(152.5641F, 69.00014F);
            this.xrLabel28.Multiline = true;
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(297.6922F, 23F);
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseForeColor = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "Kích phổi qua 2 đường";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel27
            // 
            this.xrLabel27.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(3.522635E-05F, 69.00012F);
            this.xrLabel27.Multiline = true;
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(152.5641F, 23.00002F);
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.Text = "- Phương pháp phẫu thuật:";
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel26
            // 
            this.xrLabel26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ChuanDoan]")});
            this.xrLabel26.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel26.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(87.56411F, 46.0001F);
            this.xrLabel26.Multiline = true;
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(639.1367F, 23.00002F);
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseForeColor = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.Text = "Suy hô hấp nặng";
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel25
            // 
            this.xrLabel25.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(3.522635E-05F, 46.0001F);
            this.xrLabel25.Multiline = true;
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(87.56407F, 23.00002F);
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.Text = "- Chuẩn đoán:";
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel23
            // 
            this.xrLabel23.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(620.0645F, 23.0001F);
            this.xrLabel23.Multiline = true;
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(70.70532F, 23F);
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "Nhóm máu:";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel24
            // 
            this.xrLabel24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NhomMau]")});
            this.xrLabel24.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel24.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(690.7699F, 23.00009F);
            this.xrLabel24.Multiline = true;
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(35.93091F, 23.00001F);
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseForeColor = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.Text = "AB+";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel22
            // 
            this.xrLabel22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ChieuCao]")});
            this.xrLabel22.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel22.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(564.0812F, 23.00009F);
            this.xrLabel22.Multiline = true;
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(55.98334F, 23F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseForeColor = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "180 Cm";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel21
            // 
            this.xrLabel21.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(498.3759F, 23.00008F);
            this.xrLabel21.Multiline = true;
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(65.70532F, 23F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Chiều cao:";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel20
            // 
            this.xrLabel20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CanNang]")});
            this.xrLabel20.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel20.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(452.9482F, 23.00008F);
            this.xrLabel20.Multiline = true;
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(45.42773F, 23F);
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseForeColor = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "85 Kg";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel19
            // 
            this.xrLabel19.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(380.8411F, 23.00008F);
            this.xrLabel19.Multiline = true;
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(69.85065F, 23.00001F);
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Cân nặng:";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel17
            // 
            this.xrLabel17.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(276.7945F, 23.00005F);
            this.xrLabel17.Multiline = true;
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(68.20535F, 23F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Số giường:";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel18
            // 
            this.xrLabel18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Giuong]")});
            this.xrLabel18.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel18.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(344.9998F, 23.00007F);
            this.xrLabel18.Multiline = true;
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(35.84122F, 22.99999F);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseForeColor = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "113";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel16
            // 
            this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Buong]")});
            this.xrLabel16.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel16.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(237.0724F, 23.00005F);
            this.xrLabel16.Multiline = true;
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(39.72208F, 23.00001F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseForeColor = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "113";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(190.1282F, 23.00005F);
            this.xrLabel15.Multiline = true;
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(46.94426F, 23F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "Buồng:";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Khoa2]")});
            this.xrLabel14.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel14.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(51.45298F, 23.00005F);
            this.xrLabel14.Multiline = true;
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(138.6752F, 22.99999F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseForeColor = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Gây mê hồi sức";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(1.826882E-05F, 23.00002F);
            this.xrLabel13.Multiline = true;
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(51.45296F, 23.00002F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "- Khoa:";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrCheckBox2
            // 
            this.xrCheckBox2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "Iif([GioiTinh]=\'Nữ\',true ,false)")});
            this.xrCheckBox2.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrCheckBox2.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Far;
            this.xrCheckBox2.GlyphOptions.Style = DevExpress.XtraPrinting.GlyphStyle.YesNoBox;
            this.xrCheckBox2.LocationFloat = new DevExpress.Utils.PointFloat(678.7716F, 3.051758E-05F);
            this.xrCheckBox2.Name = "xrCheckBox2";
            this.xrCheckBox2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCheckBox2.SizeF = new System.Drawing.SizeF(47.92914F, 23F);
            this.xrCheckBox2.StylePriority.UseFont = false;
            this.xrCheckBox2.Text = "Nữ";
            // 
            // xrCheckBox1
            // 
            this.xrCheckBox1.CheckBoxState = DevExpress.XtraPrinting.CheckBoxState.Checked;
            this.xrCheckBox1.Checked = true;
            this.xrCheckBox1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "Iif([GioiTinh]=\'Nam\',true ,false)")});
            this.xrCheckBox1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrCheckBox1.GlyphOptions.Alignment = DevExpress.Utils.HorzAlignment.Far;
            this.xrCheckBox1.GlyphOptions.Style = DevExpress.XtraPrinting.GlyphStyle.YesNo;
            this.xrCheckBox1.LocationFloat = new DevExpress.Utils.PointFloat(628.1909F, 3.051758E-05F);
            this.xrCheckBox1.Name = "xrCheckBox1";
            this.xrCheckBox1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCheckBox1.SizeF = new System.Drawing.SizeF(50.58069F, 23F);
            this.xrCheckBox1.StylePriority.UseFont = false;
            this.xrCheckBox1.Text = "Nam";
            // 
            // xrLabel12
            // 
            this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Tuoi]")});
            this.xrLabel12.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel12.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(584.9789F, 1.525879E-05F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(39.44452F, 23.00002F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseForeColor = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "22";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(535.5344F, 1.525879E-05F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(49.44452F, 23.00002F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Tuổi:";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel10
            // 
            this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HoTen]")});
            this.xrLabel10.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel10.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(128.8034F, 1.525879E-05F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(406.731F, 23.00001F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseForeColor = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Trần Bá Thiện";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(4.358901F, 1.525879E-05F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(124.4445F, 23.00001F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "- Họ tên người bệnh:";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrPanel1
            // 
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(726.9999F, 69.99997F);
            // 
            // xrLabel8
            // 
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Khoa1]")});
            this.xrLabel8.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel8.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(51.75218F, 46.00002F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(149.1025F, 23F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Gây mê hồi sức";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 46F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(51.75219F, 23F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Khoa:";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SoVaoVien]")});
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel6.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(637.0144F, 22.99998F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(89.98553F, 23F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "12345";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(551.7365F, 23F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(84.95679F, 23F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Số vào viện:";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 23.00001F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(173.547F, 23F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "BỆNH VIỆN NHI ĐỒNG 2";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Times New Roman", 16F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(173.547F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(378.1895F, 45.99999F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "PHIẾU GÂY MÊ HỒI SỨC";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(551.7365F, 0F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(175.2635F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "MS: 13/BV-01";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(173.547F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "SỞ Y TẾ TP. HỒ CHÍ MINH";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.DataSource = typeof(Report_WinForm_Phiếu_11_9_2023.Model.PhieuGayMeHoiSuc_Model);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // Report_PhieuGayMeHoiSuc
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1,
            this.ReportHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.DataSource = this.objectDataSource1;
            this.Margins = new DevExpress.Drawing.DXMargins(60F, 39F, 75.00001F, 47.41512F);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "22.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private ReportHeaderBand ReportHeader;
        private XRPanel xrPanel1;
        private XRLabel xrLabel1;
        private XRLabel xrLabel4;
        private XRLabel xrLabel3;
        private XRLabel xrLabel2;
        private XRLabel xrLabel6;
        private XRLabel xrLabel5;
        private XRLabel xrLabel8;
        private XRLabel xrLabel7;
        private XRPanel xrPanel2;
        private XRLabel xrLabel9;
        private XRLabel xrLabel10;
        private XRCheckBox xrCheckBox1;
        private XRLabel xrLabel12;
        private XRLabel xrLabel11;
        private XRCheckBox xrCheckBox2;
        private XRLabel xrLabel13;
        private XRLabel xrLabel19;
        private XRLabel xrLabel17;
        private XRLabel xrLabel18;
        private XRLabel xrLabel16;
        private XRLabel xrLabel15;
        private XRLabel xrLabel14;
        private XRLabel xrLabel23;
        private XRLabel xrLabel24;
        private XRLabel xrLabel22;
        private XRLabel xrLabel21;
        private XRLabel xrLabel20;
        private XRLabel xrLabel28;
        private XRLabel xrLabel27;
        private XRLabel xrLabel26;
        private XRLabel xrLabel25;
        private XRLabel xrLabel29;
        private XRLabel xrLabel32;
        private XRLabel xrLabel31;
        private XRLabel xrLabel30;
        private XRLabel xrLabel36;
        private XRLabel xrLabel35;
        private XRLabel xrLabel34;
        private XRLabel xrLabel33;
        private XRLabel xrLabel42;
        private XRLabel xrLabel41;
        private XRLabel xrLabel40;
        private XRLabel xrLabel39;
        private XRLabel xrLabel38;
        private XRLabel xrLabel37;
        private XRLabel xrLabel46;
        private XRLabel xrLabel45;
        private XRLabel xrLabel44;
        private XRLabel xrLabel43;
        private XRLabel xrLabel47;
        private XRTable xrTable2;
        private XRTableRow xrTableRow2;
        private XRTableCell xrTableCell5;
        private XRTableCell xrTableCell6;
        private XRTable xrTable3;
        private XRTableRow xrTableRow3;
        private XRTableCell xrTableCell7;
        private XRTableCell xrTableCell8;
        private XRTableCell xrTableCell9;
        private XRTableCell xrTableCell10;
        private XRTableCell xrTableCell11;
        private XRTableCell xrTableCell12;
        private XRTableCell xrTableCell13;
        private XRTableCell xrTableCell14;
        private XRTableCell xrTableCell15;
        private XRTableCell xrTableCell16;
        private XRTableCell xrTableCell17;
        private XRTableCell xrTableCell18;

        private void xrTable3_BeforePrint(object sender, CancelEventArgs e)
        {

        }

        private XRTable xrTable4;
        private XRTableRow xrTableRow4;
        private XRTableCell xrTableCell19;
        private XRLabel xrLabel55;
        private XRLabel xrLabel56;
        private XRLabel xrLabel57;
        private XRLabel xrLabel58;
        private XRLabel xrLabel59;
        private XRTableCell xrTableCell20;
        private XRLabel xrLabel60;
        private XRLabel xrLabel61;
        private XRLabel xrLabel62;
        private XRLabel xrLabel63;
        private XRLabel xrLabel64;
        private XRTableCell xrTableCell21;
        private XRLabel xrLabel65;
        private XRLabel xrLabel66;
        private XRLabel xrLabel127;
        private XRLabel xrLabel128;
        private XRLabel xrLabel129;
        private XRTableCell xrTableCell22;
        private XRLabel xrLabel130;
        private XRLabel xrLabel131;
        private XRLabel xrLabel132;
        private XRLabel xrLabel133;
        private XRLabel xrLabel134;
        private XRTableCell xrTableCell23;
        private XRLabel xrLabel135;
        private XRLabel xrLabel136;
        private XRLabel xrLabel137;
        private XRLabel xrLabel138;
        private XRLabel xrLabel139;
        private XRTableCell xrTableCell24;
        private XRLabel xrLabel140;
        private XRLabel xrLabel141;
        private XRLabel xrLabel142;
        private XRLabel xrLabel143;
        private XRLabel xrLabel144;
        private XRTableCell xrTableCell25;
        private XRLabel xrLabel145;
        private XRLabel xrLabel146;
        private XRLabel xrLabel147;
        private XRLabel xrLabel148;
        private XRLabel xrLabel149;
        private XRTableCell xrTableCell26;
        private XRLabel xrLabel150;
        private XRLabel xrLabel151;
        private XRLabel xrLabel152;
        private XRLabel xrLabel153;
        private XRLabel xrLabel154;
        private XRTableCell xrTableCell27;
        private XRLabel xrLabel155;
        private XRLabel xrLabel156;
        private XRLabel xrLabel157;
        private XRLabel xrLabel158;
        private XRLabel xrLabel159;
        private XRTableCell xrTableCell28;
        private XRLabel xrLabel160;
        private XRLabel xrLabel161;
        private XRLabel xrLabel162;
        private XRLabel xrLabel163;
        private XRLabel xrLabel164;
        private XRTableCell xrTableCell29;
        private XRLabel xrLabel165;
        private XRLabel xrLabel166;
        private XRLabel xrLabel167;
        private XRLabel xrLabel168;
        private XRLabel xrLabel169;
        private XRTableCell xrTableCell30;
        private XRLabel xrLabel170;
        private XRLabel xrLabel171;
        private XRLabel xrLabel172;
        private XRLabel xrLabel173;
        private XRLabel xrLabel174;
        private XRLabel xrLabel71;
        private XRLabel xrLabel70;
        private XRLabel xrLabel69;
        private XRLabel xrLabel68;
        private XRLabel xrLabel67;
        private XRLabel xrLabel72;
        private XRLabel xrLabel73;
        private XRLabel xrLabel74;
        private XRLabel xrLabel75;
        private XRLabel xrLabel76;
        private XRLabel xrLabel77;
        private XRLabel xrLabel78;
        private XRLabel xrLabel79;
        private XRLabel xrLabel80;
        private XRLabel xrLabel81;
        private XRLabel xrLabel82;
        private XRLabel xrLabel83;
        private XRLabel xrLabel84;
        private XRLabel xrLabel85;
        private XRLabel xrLabel86;
        private XRLabel xrLabel87;
        private XRLabel xrLabel88;
        private XRLabel xrLabel89;
        private XRLabel xrLabel90;
        private XRLabel xrLabel91;
        private XRLabel xrLabel92;
        private XRLabel xrLabel93;
        private XRLabel xrLabel94;
        private XRLabel xrLabel95;
        private XRLabel xrLabel96;
        private XRLabel xrLabel97;
        private XRLabel xrLabel98;
        private XRLabel xrLabel99;
        private XRLabel xrLabel100;
        private XRLabel xrLabel101;
        private XRLabel xrLabel102;
        private XRLabel xrLabel103;
        private XRLabel xrLabel104;
        private XRLabel xrLabel105;
        private XRLabel xrLabel106;
        private XRLabel xrLabel107;
        private XRLabel xrLabel108;
        private XRLabel xrLabel109;
        private XRLabel xrLabel110;
        private XRLabel xrLabel111;
        private XRLabel xrLabel112;
        private XRLabel xrLabel113;
        private XRLabel xrLabel114;
        private XRLabel xrLabel115;
        private XRLabel xrLabel116;
        private XRLabel xrLabel117;
        private XRLabel xrLabel118;
        private XRLabel xrLabel119;
        private XRLabel xrLabel120;
        private XRLabel xrLabel121;
        private XRLabel xrLabel122;
        private XRLabel xrLabel123;
        private XRLabel xrLabel124;
        private XRLabel xrLabel125;
        private XRLabel xrLabel126;
        private XRTable xrTable6;
        private XRTableRow xrTableRow6;
        private XRTableCell xrTableCell43;
        private XRLabel xrLabel295;
        private XRLabel xrLabel235;
        private XRLabel xrLabel236;
        private XRLabel xrLabel237;
        private XRLabel xrLabel238;
        private XRLabel xrLabel239;
        private XRTableCell xrTableCell44;
        private XRLabel xrLabel296;
        private XRLabel xrLabel240;
        private XRLabel xrLabel241;
        private XRLabel xrLabel242;
        private XRLabel xrLabel243;
        private XRLabel xrLabel244;
        private XRTableCell xrTableCell45;
        private XRLabel xrLabel297;
        private XRLabel xrLabel245;
        private XRLabel xrLabel246;
        private XRLabel xrLabel247;
        private XRLabel xrLabel248;
        private XRLabel xrLabel249;
        private XRTableCell xrTableCell46;
        private XRLabel xrLabel298;
        private XRLabel xrLabel250;
        private XRLabel xrLabel251;
        private XRLabel xrLabel252;
        private XRLabel xrLabel253;
        private XRLabel xrLabel254;
        private XRTableCell xrTableCell47;
        private XRLabel xrLabel299;
        private XRLabel xrLabel255;
        private XRLabel xrLabel256;
        private XRLabel xrLabel257;
        private XRLabel xrLabel258;
        private XRLabel xrLabel259;
        private XRTableCell xrTableCell48;
        private XRLabel xrLabel300;
        private XRLabel xrLabel260;
        private XRLabel xrLabel261;
        private XRLabel xrLabel262;
        private XRLabel xrLabel263;
        private XRLabel xrLabel264;
        private XRTableCell xrTableCell49;
        private XRLabel xrLabel301;
        private XRLabel xrLabel265;
        private XRLabel xrLabel266;
        private XRLabel xrLabel267;
        private XRLabel xrLabel268;
        private XRLabel xrLabel269;
        private XRTableCell xrTableCell50;
        private XRLabel xrLabel302;
        private XRLabel xrLabel270;
        private XRLabel xrLabel271;
        private XRLabel xrLabel272;
        private XRLabel xrLabel273;
        private XRLabel xrLabel274;
        private XRTableCell xrTableCell51;
        private XRLabel xrLabel303;
        private XRLabel xrLabel275;
        private XRLabel xrLabel276;
        private XRLabel xrLabel277;
        private XRLabel xrLabel278;
        private XRLabel xrLabel279;
        private XRTableCell xrTableCell52;
        private XRLabel xrLabel304;
        private XRLabel xrLabel280;
        private XRLabel xrLabel281;
        private XRLabel xrLabel282;
        private XRLabel xrLabel283;
        private XRLabel xrLabel284;
        private XRTableCell xrTableCell53;
        private XRLabel xrLabel305;
        private XRLabel xrLabel285;
        private XRLabel xrLabel286;
        private XRLabel xrLabel287;
        private XRLabel xrLabel288;
        private XRLabel xrLabel289;
        private XRTableCell xrTableCell54;
        private XRLabel xrLabel306;
        private XRLabel xrLabel290;
        private XRLabel xrLabel291;
        private XRLabel xrLabel292;
        private XRLabel xrLabel293;
        private XRLabel xrLabel294;
        private XRTable xrTable5;
        private XRTableRow xrTableRow5;
        private XRTableCell xrTableCell31;
        private XRLabel xrLabel175;
        private XRLabel xrLabel176;
        private XRLabel xrLabel177;
        private XRLabel xrLabel178;
        private XRLabel xrLabel179;
        private XRTableCell xrTableCell32;
        private XRLabel xrLabel180;
        private XRLabel xrLabel181;
        private XRLabel xrLabel182;
        private XRLabel xrLabel183;
        private XRLabel xrLabel184;
        private XRTableCell xrTableCell33;
        private XRLabel xrLabel185;
        private XRLabel xrLabel186;
        private XRLabel xrLabel187;
        private XRLabel xrLabel188;
        private XRLabel xrLabel189;
        private XRTableCell xrTableCell34;
        private XRLabel xrLabel190;
        private XRLabel xrLabel191;
        private XRLabel xrLabel192;
        private XRLabel xrLabel193;
        private XRLabel xrLabel194;
        private XRTableCell xrTableCell35;
        private XRLabel xrLabel195;
        private XRLabel xrLabel196;
        private XRLabel xrLabel197;
        private XRLabel xrLabel198;
        private XRLabel xrLabel199;
        private XRTableCell xrTableCell36;
        private XRLabel xrLabel200;
        private XRLabel xrLabel201;
        private XRLabel xrLabel202;
        private XRLabel xrLabel203;
        private XRLabel xrLabel204;
        private XRTableCell xrTableCell37;
        private XRLabel xrLabel205;
        private XRLabel xrLabel206;
        private XRLabel xrLabel207;
        private XRLabel xrLabel208;
        private XRLabel xrLabel209;
        private XRTableCell xrTableCell38;
        private XRLabel xrLabel210;
        private XRLabel xrLabel211;
        private XRLabel xrLabel212;
        private XRLabel xrLabel213;
        private XRLabel xrLabel214;
        private XRTableCell xrTableCell39;
        private XRLabel xrLabel215;
        private XRLabel xrLabel216;
        private XRLabel xrLabel217;
        private XRLabel xrLabel218;
        private XRLabel xrLabel219;
        private XRTableCell xrTableCell40;
        private XRLabel xrLabel220;
        private XRLabel xrLabel221;
        private XRLabel xrLabel222;
        private XRLabel xrLabel223;
        private XRLabel xrLabel224;
        private XRTableCell xrTableCell41;
        private XRLabel xrLabel225;
        private XRLabel xrLabel226;
        private XRLabel xrLabel227;
        private XRLabel xrLabel228;
        private XRLabel xrLabel229;
        private XRTableCell xrTableCell42;
        private XRLabel xrLabel230;
        private XRLabel xrLabel231;
        private XRLabel xrLabel232;
        private XRLabel xrLabel233;
        private XRLabel xrLabel234;
        private XRLabel xrLabel311;
        private XRLabel xrLabel310;
        private XRLabel xrLabel309;
        private XRLabel xrLabel308;
        private XRLabel xrLabel307;
        private XRLabel xrLabel312;
        private XRLabel xrLabel313;
        private XRLabel xrLabel314;
        private XRLabel xrLabel315;
        private XRLabel xrLabel316;
        private XRLabel xrLabel317;
        private XRTable xrTable1;
        private XRTableRow xrTableRow1;
        private XRTableCell xrTableCell1;
        private XRLabel xrLabel318;
        private XRTableCell xrTableCell2;
        private XRTableCell xrTableCell3;
        private XRTableCell xrTableCell4;
        private XRPanel xrPanel3;
        private XRLabel xrLabel48;
        private XRLabel xrLabel49;
        private XRLabel xrLabel50;
        private XRLabel xrLabel51;
        private XRLabel xrLabel52;
        private XRLabel xrLabel53;
        private XRLabel xrLabel54;
        private XRLabel xrLabel319;
        private XRLabel xrLabel324;
        private XRLabel xrLabel323;
        private XRLabel xrLabel322;
        private XRLabel xrLabel321;
        private XRLabel xrLabel320;

        private void xrLabel324_BeforePrint(object sender, CancelEventArgs e)
        {

        }

        private XRLabel xrLabel325;

        private void xrLabel325_BeforePrint(object sender, CancelEventArgs e)
        {

        }

        private XRLabel xrLabel330;
        private XRLabel xrLabel328;
        private XRLabel xrLabel327;
        private XRLabel xrLabel326;
        private XRLabel xrLabel334;
        private XRLabel xrLabel333;
        private XRLabel xrLabel332;
        private XRLabel xrLabel331;
        private XRLabel xrLabel336;
        private XRLabel xrLabel335;
        private XRTable xrTable7;
        private XRTableRow xrTableRow7;
        private XRTableCell xrTableCell55;
        private XRLabel xrLabel340;
        private XRLabel xrLabel341;
        private XRTableCell xrTableCell56;
        private XRLabel xrLabel346;
        private XRLabel xrLabel347;
        private XRTableCell xrTableCell57;
        private XRLabel xrLabel352;
        private XRLabel xrLabel353;
        private XRTableCell xrTableCell58;
        private XRLabel xrLabel358;
        private XRLabel xrLabel359;
        private XRTableCell xrTableCell59;
        private XRLabel xrLabel364;
        private XRLabel xrLabel365;
        private XRTableCell xrTableCell60;
        private XRLabel xrLabel370;
        private XRLabel xrLabel371;
        private XRTableCell xrTableCell61;
        private XRLabel xrLabel376;
        private XRLabel xrLabel377;
        private XRTableCell xrTableCell62;
        private XRLabel xrLabel382;
        private XRLabel xrLabel383;
        private XRTableCell xrTableCell63;
        private XRLabel xrLabel388;
        private XRLabel xrLabel389;
        private XRTableCell xrTableCell64;
        private XRLabel xrLabel394;
        private XRLabel xrLabel395;
        private XRTableCell xrTableCell65;
        private XRLabel xrLabel400;
        private XRLabel xrLabel401;
        private XRTableCell xrTableCell66;
        private XRLabel xrLabel406;
        private XRLabel xrLabel407;
        private XRTable xrTable9;
        private XRTableRow xrTableRow9;
        private XRTableCell xrTableCell79;
        private XRTableCell xrTableCell80;
        private XRTableCell xrTableCell81;
        private XRLabel xrLabel436;
        private XRTableCell xrTableCell82;
        private XRLabel xrLabel438;
        private XRLabel xrLabel439;
        private XRTableCell xrTableCell83;
        private XRLabel xrLabel440;
        private XRLabel xrLabel441;
        private XRTableCell xrTableCell84;
        private XRLabel xrLabel442;
        private XRLabel xrLabel443;
        private XRTableCell xrTableCell85;
        private XRLabel xrLabel444;
        private XRLabel xrLabel445;
        private XRTableCell xrTableCell86;
        private XRLabel xrLabel446;
        private XRLabel xrLabel447;
        private XRTableCell xrTableCell87;
        private XRLabel xrLabel448;
        private XRLabel xrLabel449;
        private XRTableCell xrTableCell88;
        private XRLabel xrLabel450;
        private XRLabel xrLabel451;
        private XRTableCell xrTableCell89;
        private XRLabel xrLabel452;
        private XRLabel xrLabel453;
        private XRTableCell xrTableCell90;
        private XRLabel xrLabel454;
        private XRLabel xrLabel455;
        private XRTable xrTable8;
        private XRTableRow xrTableRow8;
        private XRTableCell xrTableCell67;
        private XRLabel xrLabel329;
        private XRLabel xrLabel337;
        private XRLabel xrLabel338;
        private XRLabel xrLabel339;
        private XRLabel xrLabel342;
        private XRLabel xrLabel343;
        private XRTableCell xrTableCell68;
        private XRLabel xrLabel344;
        private XRLabel xrLabel345;
        private XRLabel xrLabel348;
        private XRLabel xrLabel349;
        private XRLabel xrLabel350;
        private XRLabel xrLabel351;
        private XRTableCell xrTableCell69;
        private XRLabel xrLabel354;
        private XRLabel xrLabel355;
        private XRLabel xrLabel356;
        private XRLabel xrLabel357;
        private XRLabel xrLabel360;
        private XRLabel xrLabel361;
        private XRTableCell xrTableCell70;
        private XRLabel xrLabel362;
        private XRLabel xrLabel363;
        private XRLabel xrLabel366;
        private XRLabel xrLabel367;
        private XRLabel xrLabel368;
        private XRLabel xrLabel369;
        private XRTableCell xrTableCell71;
        private XRLabel xrLabel372;
        private XRLabel xrLabel373;
        private XRLabel xrLabel374;
        private XRLabel xrLabel375;
        private XRLabel xrLabel378;
        private XRLabel xrLabel379;
        private XRTableCell xrTableCell72;
        private XRLabel xrLabel380;
        private XRLabel xrLabel381;
        private XRLabel xrLabel384;
        private XRLabel xrLabel385;
        private XRLabel xrLabel386;
        private XRLabel xrLabel387;
        private XRTableCell xrTableCell73;
        private XRLabel xrLabel390;
        private XRLabel xrLabel391;
        private XRLabel xrLabel392;
        private XRLabel xrLabel393;
        private XRLabel xrLabel396;
        private XRLabel xrLabel397;
        private XRTableCell xrTableCell74;
        private XRLabel xrLabel398;
        private XRLabel xrLabel399;
        private XRLabel xrLabel402;
        private XRLabel xrLabel403;
        private XRLabel xrLabel404;
        private XRLabel xrLabel405;
        private XRTableCell xrTableCell75;
        private XRLabel xrLabel408;
        private XRLabel xrLabel409;
        private XRLabel xrLabel410;
        private XRLabel xrLabel411;
        private XRLabel xrLabel412;
        private XRLabel xrLabel413;
        private XRTableCell xrTableCell76;
        private XRLabel xrLabel414;
        private XRLabel xrLabel415;
        private XRLabel xrLabel416;
        private XRLabel xrLabel417;
        private XRLabel xrLabel418;
        private XRLabel xrLabel419;
        private XRTableCell xrTableCell77;
        private XRLabel xrLabel420;
        private XRLabel xrLabel421;
        private XRLabel xrLabel422;
        private XRLabel xrLabel423;
        private XRLabel xrLabel424;
        private XRLabel xrLabel425;
        private XRTableCell xrTableCell78;
        private XRLabel xrLabel426;
        private XRLabel xrLabel427;
        private XRLabel xrLabel428;
        private XRLabel xrLabel429;
        private XRLabel xrLabel430;
        private XRLabel xrLabel431;
        private XRLabel xrLabel432;
        private XRLabel xrLabel433;
        private XRLabel xrLabel434;
        private XRLabel xrLabel435;
        private XRLabel xrLabel437;

        private void xrTableCell79_BeforePrint(object sender, CancelEventArgs e)
        {
            
        }

        private void xrTableCell79_Draw(object sender, DrawEventArgs e)
        {
           
        }

        private XRLine xrLine1;
        private XRLine xrLine2;
        private XRLine xrLine3;
        private XRLine xrLine4;
        private XRLine xrLine5;
        private XRLine xrLine6;
        private XRLine xrLine7;
        private XRLine xrLine8;
        private XRLine xrLine9;
        private XRLine xrLine10;
        private XRLine xrLine11;
        private XRLine xrLine12;
        private XRPanel xrPanel4;
        private XRLabel xrLabel456;
        private XRTable xrTable11;
        private XRTableRow xrTableRow11;
        private XRTableCell xrTableCell103;
        private XRLabel xrLabel529;
        private XRLabel xrLabel530;
        private XRLabel xrLabel531;
        private XRLabel xrLabel532;
        private XRLabel xrLabel533;
        private XRLabel xrLabel534;
        private XRTableCell xrTableCell104;
        private XRLabel xrLabel535;
        private XRLabel xrLabel536;
        private XRLabel xrLabel537;
        private XRLabel xrLabel538;
        private XRLabel xrLabel539;
        private XRLabel xrLabel540;
        private XRTableCell xrTableCell105;
        private XRLabel xrLabel541;
        private XRLabel xrLabel542;
        private XRLabel xrLabel543;
        private XRLabel xrLabel544;
        private XRLabel xrLabel545;
        private XRLabel xrLabel546;
        private XRTableCell xrTableCell106;
        private XRLabel xrLabel547;
        private XRLabel xrLabel548;
        private XRLabel xrLabel549;
        private XRLabel xrLabel550;
        private XRLabel xrLabel551;
        private XRLabel xrLabel552;
        private XRTableCell xrTableCell107;
        private XRLabel xrLabel553;
        private XRLabel xrLabel554;
        private XRLabel xrLabel555;
        private XRLabel xrLabel556;
        private XRLabel xrLabel557;
        private XRLabel xrLabel558;
        private XRTableCell xrTableCell108;
        private XRLabel xrLabel559;
        private XRLabel xrLabel560;
        private XRLabel xrLabel561;
        private XRLabel xrLabel562;
        private XRLabel xrLabel563;
        private XRLabel xrLabel564;
        private XRTableCell xrTableCell109;
        private XRLabel xrLabel565;
        private XRLabel xrLabel566;
        private XRLabel xrLabel567;
        private XRLabel xrLabel568;
        private XRLabel xrLabel569;
        private XRLabel xrLabel570;
        private XRTableCell xrTableCell110;
        private XRLabel xrLabel571;
        private XRLabel xrLabel572;
        private XRLabel xrLabel573;
        private XRLabel xrLabel574;
        private XRLabel xrLabel575;
        private XRLabel xrLabel576;
        private XRTableCell xrTableCell111;
        private XRLabel xrLabel577;
        private XRLabel xrLabel578;
        private XRLabel xrLabel579;
        private XRLabel xrLabel580;
        private XRLabel xrLabel581;
        private XRLabel xrLabel582;
        private XRTableCell xrTableCell112;
        private XRLabel xrLabel583;
        private XRLabel xrLabel584;
        private XRLabel xrLabel585;
        private XRLabel xrLabel586;
        private XRLabel xrLabel587;
        private XRLabel xrLabel588;
        private XRTableCell xrTableCell113;
        private XRLabel xrLabel589;
        private XRLabel xrLabel590;
        private XRLabel xrLabel591;
        private XRLabel xrLabel592;
        private XRLabel xrLabel593;
        private XRLabel xrLabel594;
        private XRTableCell xrTableCell114;
        private XRLabel xrLabel595;
        private XRLabel xrLabel596;
        private XRLabel xrLabel597;
        private XRLabel xrLabel598;
        private XRLabel xrLabel599;
        private XRLabel xrLabel600;
        private XRTable xrTable10;
        private XRTableRow xrTableRow10;
        private XRTableCell xrTableCell91;
        private XRLabel xrLabel457;
        private XRLabel xrLabel458;
        private XRLabel xrLabel459;
        private XRLabel xrLabel460;
        private XRLabel xrLabel461;
        private XRLabel xrLabel462;
        private XRTableCell xrTableCell92;
        private XRLabel xrLabel463;
        private XRLabel xrLabel464;
        private XRLabel xrLabel465;
        private XRLabel xrLabel466;
        private XRLabel xrLabel467;
        private XRLabel xrLabel468;
        private XRTableCell xrTableCell93;
        private XRLabel xrLabel469;
        private XRLabel xrLabel470;
        private XRLabel xrLabel471;
        private XRLabel xrLabel472;
        private XRLabel xrLabel473;
        private XRLabel xrLabel474;
        private XRTableCell xrTableCell94;
        private XRLabel xrLabel475;
        private XRLabel xrLabel476;
        private XRLabel xrLabel477;
        private XRLabel xrLabel478;
        private XRLabel xrLabel479;
        private XRLabel xrLabel480;
        private XRTableCell xrTableCell95;
        private XRLabel xrLabel481;
        private XRLabel xrLabel482;
        private XRLabel xrLabel483;
        private XRLabel xrLabel484;
        private XRLabel xrLabel485;
        private XRLabel xrLabel486;
        private XRTableCell xrTableCell96;
        private XRLabel xrLabel487;
        private XRLabel xrLabel488;
        private XRLabel xrLabel489;
        private XRLabel xrLabel490;
        private XRLabel xrLabel491;
        private XRLabel xrLabel492;
        private XRTableCell xrTableCell97;
        private XRLabel xrLabel493;
        private XRLabel xrLabel494;
        private XRLabel xrLabel495;
        private XRLabel xrLabel496;
        private XRLabel xrLabel497;
        private XRLabel xrLabel498;
        private XRTableCell xrTableCell98;
        private XRLabel xrLabel499;
        private XRLabel xrLabel500;
        private XRLabel xrLabel501;
        private XRLabel xrLabel502;
        private XRLabel xrLabel503;
        private XRLabel xrLabel504;
        private XRTableCell xrTableCell99;
        private XRLabel xrLabel505;
        private XRLabel xrLabel506;
        private XRLabel xrLabel507;
        private XRLabel xrLabel508;
        private XRLabel xrLabel509;
        private XRLabel xrLabel510;
        private XRTableCell xrTableCell100;
        private XRLabel xrLabel511;
        private XRLabel xrLabel512;
        private XRLabel xrLabel513;
        private XRLabel xrLabel514;
        private XRLabel xrLabel515;
        private XRLabel xrLabel516;
        private XRTableCell xrTableCell101;
        private XRLabel xrLabel517;
        private XRLabel xrLabel518;
        private XRLabel xrLabel519;
        private XRLabel xrLabel520;
        private XRLabel xrLabel521;
        private XRLabel xrLabel522;
        private XRTableCell xrTableCell102;
        private XRLabel xrLabel523;
        private XRLabel xrLabel524;
        private XRLabel xrLabel525;
        private XRLabel xrLabel526;
        private XRLabel xrLabel527;
        private XRLabel xrLabel528;
        private XRLabel xrLabel601;
        private XRTable xrTable14;
        private XRTableRow xrTableRow14;
        private XRTableCell xrTableCell119;
        private XRTableCell xrTableCell120;
        private XRTable xrTable13;
        private XRTableRow xrTableRow13;
        private XRTableCell xrTableCell116;
        private XRTableCell xrTableCell118;
        private XRTable xrTable12;
        private XRTableRow xrTableRow12;
        private XRTableCell xrTableCell115;
        private XRTableCell xrTableCell117;
        private XRPanel xrPanel5;
        private XRLine xrLine13;
        private XRLine xrLine15;
        private XRLine xrLine14;
        private XRLabel xrLabel602;
        private XRPanel xrPanel6;
        private XRLabel xrLabel606;
        private XRLabel xrLabel605;
        private XRLabel xrLabel604;
        private XRLabel xrLabel603;
        private XRPanel xrPanel7;
        private XRLabel xrLabel611;
        private XRLabel xrLabel610;
        private XRLabel xrLabel609;
        private XRLabel xrLabel608;
        private XRLabel xrLabel607;
        private XRLabel xrLabel616;
        private XRLabel xrLabel615;
        private XRLabel xrLabel614;
        private XRLabel xrLabel613;
        private XRLabel xrLabel612;
        private XRLabel xrLabel621;
        private XRLabel xrLabel620;
        private XRLabel xrLabel619;
        private XRLabel xrLabel618;
        private XRLabel xrLabel617;
        private XRLabel xrLabel627;
        private XRLabel xrLabel626;
        private XRLabel xrLabel625;
        private XRLabel xrLabel624;
        private XRLabel xrLabel623;
        private XRLabel xrLabel622;
        private XRLabel xrLabel629;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private IContainer components;
    }
}
