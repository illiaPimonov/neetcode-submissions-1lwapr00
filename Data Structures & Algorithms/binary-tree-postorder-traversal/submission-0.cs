/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public List<int> PostorderTraversal(TreeNode root) {
        List<int> res = new List<int>();
        postorder(root,res);
        return res;
    }
    public void postorder(TreeNode root,List<int> res){
        if(root != null){
            postorder(root.left,res);
            postorder(root.right,res);
            res.Add(root.val);
        }
    }
}