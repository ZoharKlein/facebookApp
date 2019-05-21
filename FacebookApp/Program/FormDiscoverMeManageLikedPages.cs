using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Program
{
    internal partial class FormDiscoverMeManageLikedPages : Form
    {
        public FormDiscoverMeManageLikedPages()
        {
            InitializeComponent();
        }

        private readonly FacadeFormDiscoverMeManageLikedPages r_FacadeFormDiscoverMeManageLikedPages = new FacadeFormDiscoverMeManageLikedPages();
        private LikedPagesComposite m_LikedPagesComposite;

        internal void ShowFormLikedPages(User i_LoggedInUser)
        {
            r_FacadeFormDiscoverMeManageLikedPages.LoggedInUser = i_LoggedInUser;
            initializeFormData();
            this.ShowDialog();
        }

        private void initializeFormData()
        {
            if (!this.IsHandleCreated)
            {
                IntPtr handle = this.Handle;
            }

            if (this.IsHandleCreated == true)
            {
                new Thread(fetchLikedPages).Start();
                fetchLikedPagesCategories();
            }
        }

        private void fetchLikedPages()
        {
            pageBindingSource.DataSource = this.r_FacadeFormDiscoverMeManageLikedPages.LoggedInUser.LikedPages;
        }

        private void fetchLikedPagesCategories()
        {
            createTreeViewOfLikedPages();
        }

        private void createTreeViewOfLikedPages()
        {
            if(this.m_LikedPagesComposite == null)
            {
                this.r_FacadeFormDiscoverMeManageLikedPages.CreateNewCompositeItem(string.Format("All Categories"));
                this.m_LikedPagesComposite = this.r_FacadeFormDiscoverMeManageLikedPages.m_LikedPagesComposite;
                this.m_LikedPagesComposite.Node = new TreeNodeProxy(this.m_LikedPagesComposite.LikedPageName, this.m_LikedPagesComposite);
                this.treeView_Liked_Pages_Category.Nodes.Add(this.m_LikedPagesComposite.Node);
            }
        }

        private void button_Create_Category_Click(object sender, EventArgs e)
        {
            if (this.textBox_Create_Category.Text != string.Empty)
            {
                this.button_Create_Category.Enabled = true;
            }
            else
            {
                this.button_Create_Category.Enabled = false;
            }

            if (treeView_Liked_Pages_Category.SelectedNode != null)
            {
                updateTreeViewAfterCategoryAdded();
            }
        }

        private void updateTreeViewAfterCategoryAdded()
        {
            this.r_FacadeFormDiscoverMeManageLikedPages.CreateNewCompositeItem(string.Format(textBox_Create_Category.Text));
            LikedPagesComposite addNewCategory = this.r_FacadeFormDiscoverMeManageLikedPages.m_LikedPagesComposite;
            TreeNodeProxy addBelowCategory = treeView_Liked_Pages_Category.SelectedNode as TreeNodeProxy;
            (addBelowCategory.Node as LikedPagesComposite).OnAddPageComponent(addNewCategory);
        }

        private void button_Remove_Selected_Item_Click(object sender, EventArgs e)
        {
            updateTreeViewAfterCategoryOrPageRemoved();
        }

        private void updateTreeViewAfterCategoryOrPageRemoved()
        {
            TreeNodeProxy selectedCategory = treeView_Liked_Pages_Category.SelectedNode as TreeNodeProxy;
            this.r_FacadeFormDiscoverMeManageLikedPages.CreateNewCompositeItem(selectedCategory.Node.LikedPageName);
            LikedPagesComposite pageComponentToRemove = this.r_FacadeFormDiscoverMeManageLikedPages.m_LikedPagesComposite;
            pageComponentToRemove.Node = selectedCategory;

            if (selectedCategory.Node is LikedPagesComposite)
            {
                (selectedCategory.Node as LikedPagesComposite).OnRemovePageComponent(pageComponentToRemove);
            }
            else if (selectedCategory.Node is LikedPagesItem)
            {
                (selectedCategory.Node as LikedPagesItem).OnRemovePageComponent(pageComponentToRemove);
            }

            treeView_Liked_Pages_Category.SelectedNode.Remove();
        }

        private void listBox_Liked_Pages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (treeView_Liked_Pages_Category.SelectedNode != null)
            {
                button_Add_Page_To_Selected_Category.Enabled = true;
            }
        }

        private void listBox_Liked_Pages_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Liked_Pages.SelectedIndex >= 0)
            {
                this.button_Add_Page_To_Selected_Category.Enabled = true;
            }
        }

        private void button_Add_Page_To_Selected_Category_Click(object sender, EventArgs e)
        {
            this.r_FacadeFormDiscoverMeManageLikedPages.CreateNewItem(string.Format(listBox_Liked_Pages.SelectedItem.ToString()));
            LikedPagesItem addNewItem = this.r_FacadeFormDiscoverMeManageLikedPages.m_LikedPagesItem;
            TreeNodeProxy selectedNode = treeView_Liked_Pages_Category.SelectedNode as TreeNodeProxy;
            if (selectedNode.Node is LikedPagesComposite)
            {
                (selectedNode.Node as LikedPagesComposite).OnAddPageComponent(addNewItem);
            }
        }

        private void textBox_Create_Category_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox_Create_Category.Text != string.Empty)
            {
                this.button_Create_Category.Enabled = true;
            }
            else
            {
                this.button_Create_Category.Enabled = false;
            }
        }

        private void FormDiscoverMeManageLikedPages_Click(object sender, EventArgs e)
        {
            this.button_Create_Category.Enabled = false;
            this.button_Remove_Selected_Item.Enabled = false;
            this.textBox_Create_Category.Text = string.Empty;
        }

        private void treeView_Liked_Pages_Category_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.button_Remove_Selected_Item.Enabled = true;
        }
    } 
}
